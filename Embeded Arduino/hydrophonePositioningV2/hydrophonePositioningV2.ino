#define ver "v2.2.2 - 2023-05-24"
// Init pin defs
#define EnableY 2 // ClearPath ~enable input; +enable = BLU wire; -enable = ORN wire
#define InputAY 3 // ClearPath Input A; +InputA = WHT wire; -InputA is BRN wire
#define InputBY 4 // ClearPath Input B; +InputB = BLK wire; -InputB = YEL wire
#define HLFBY 5 // ClearPath HLFB Output; +HLFB = GRN wire; -HLFB = RED wire
#define EnableX 6 // ClearPath ~enable input; +enable = BLU wire; -enable = ORN wire
#define InputAX 7 // ClearPath Input A; +InputA = WHT wire; -InputA is BRN wire
#define InputBX 8 // ClearPath Input B; +InputB = BLK wire; -InputB = YEL wire
#define HLFBX 9 // ClearPath HLFB Output; +HLFB = GRN wire; -HLFB = RED wire
#define xducerTrg 10 // Signal to transducer box
#define LEDpin 13 // Arduino on-board LED

// Init Global Vars:
int loopstate = 0; // loop state machine # - 0 is "waiting"
long xloc = 0;     // Current x location, in pulses
long xtarget = 0;  // Target x location, in pulses
long xPulsRemain = 0; // remaining pulses to send to x motor
long yloc = 0;
long ytarget = 0;
long yPulsRemain = 0; // remaining pulses to send to y motor
int trgDelay = 5000; // [us] delay between trigger out pulses
int trgHiTm = 50; // [us]  trigger "high" duration
int ntrg = 6; // number of trigger out pulses
int trgremain = 0; // # trigger pulses remaining
unsigned long tlastpuls = 0; // [ms] time of last pulse, used for timing
unsigned long tcurrent = 0; // container for "current" time, used for timing
unsigned long tmovestart = 0;
int pulsdelay = 20;  // [us] 1/2 the pulse period
int HLFBxAccum; // accumulator for HLFB bits.  Change data type to increase averaging time
int HLFByAccum;
byte HLFBstatus = 0b11;

// init global flags
bool f_autotrg = 0;
bool f_LocKnown = 0;
bool f_trgContinuous = 0;
bool f_homing = 0;

void setup() {
  // Setup Pin I/O:
  pinMode(LEDpin, OUTPUT);
  pinMode(EnableX, OUTPUT);
  pinMode(InputAX, OUTPUT);
  pinMode(InputBX, OUTPUT);
  pinMode(HLFBX, INPUT_PULLUP);
  pinMode(LEDpin, OUTPUT);
  pinMode(EnableY, OUTPUT);
  pinMode(InputAY, OUTPUT);
  pinMode(InputBY, OUTPUT);
  pinMode(HLFBY, INPUT_PULLUP);
  pinMode(xducerTrg, OUTPUT);
  //pinMode(Ducerback,INPUT);
  digitalWrite(xducerTrg, LOW);

  // init motor communication pins
  digitalWrite(EnableX, LOW); // disable motors
  digitalWrite(EnableY, LOW);
  delay(10);
  digitalWrite(InputAX, LOW); // set motor comms low
  digitalWrite(InputBX, LOW);
  digitalWrite(InputAY, LOW);
  digitalWrite(InputBY, LOW);

  // Setup Serial:
  Serial.begin(9600);
  Serial.setTimeout(100); // maximum wait ms for Serial.parse*() commands
  while (!Serial) {} //wait for builtin usb serial to init
}

void loop() {
  // main loop contains STATE MACHINE and LED CONTROL
  //   designed to loop frequently to maximize responsiveness to serial commands, esp. abort
  //   delay() only when motor com (Input**) or trigger (xducerTrg) is high
  //   Note that loop execution frequency is NOT constant.
  // serialEvent() runs @ end of each main loop if serial data is waiting
  //   Contains all serial command parsing
  //   STATE MACHINE loop state set in response to serial commands

  // State Machine
  switch (loopstate) {
    case 1: // HOMING INIT
      f_LocKnown = 0;
      // cycle motor enable (clear possible errors)
      digitalWrite(EnableX, LOW);
      digitalWrite(EnableY, LOW);
      delay(100);
      digitalWrite(EnableX, HIGH);
      digitalWrite(EnableY, HIGH);
      f_homing = 1; // set homing flag
      // per clearpath manual, "manual hard stop homing sequence"
      //  is just "issue a move toward the Physical Home ... long enough to
      //  guarantee the load will hit the hard stop" (p.188)
      // Therefore, set x/y directions to negative and pulseremain to something
      //  large and advance to MOVESEND (4)
      xtarget = 0; // used in MOVEWAIT (5) to set x/yloc
      ytarget = 0;
      digitalWrite(InputAX, LOW); // set X dir to negative
      digitalWrite(InputAY, LOW); // set Y dir to negative
      xPulsRemain = 629000; // max pulses for whole travel range (1000mm * 0.629rev/mm * 1000pulse/rev = 629000)
      yPulsRemain = 629000;
      tmovestart = micros();
      loopstate = 4; // advance to MOVESEND state
      break;
    //    case 2: // HOMING WAIT - DEPRICATED
    //      // **if HLFBx true && HLFBy true
    //      f_LocKnown = 1;
    //      xloc = 0;
    //      yloc = 0;
    //      loopstate = 0; // return to WAITING
    //      break;
    case 3: // MOVE INIT
      if (f_LocKnown) {
        digitalWrite(EnableX, HIGH); // motor enable
        digitalWrite(EnableY, HIGH);
        delay(1);
        // Calculate X move
        xPulsRemain = (long)((long)xtarget - (long)xloc); // may be negative.
        if (xPulsRemain < 0) {
          digitalWrite(InputAX, LOW); // set xdir to -
          xPulsRemain = abs(xPulsRemain);
        }
        else {
          digitalWrite(InputAX, HIGH); // set xdir to +
        }
        Serial.println(xPulsRemain);
        // Calculate Y move
        yPulsRemain = (long)((long)ytarget - (long)yloc); // may be negative.
        if (yPulsRemain < 0) {
          digitalWrite(InputAY, LOW); // set ydir to -
          yPulsRemain = abs(yPulsRemain);
        }
        else {
          digitalWrite(InputAY, HIGH); // set ydir to +
        }
        Serial.println(yPulsRemain);

        f_LocKnown = 0;
        tmovestart = micros();
        loopstate = 4; // advance to MOVE SEND
        // no break
      }
      else { // error handling - don't move if Arduino is unsure of stage location
        Serial.println("ERROR: stage is in unknown state.  Home axes before proceeding");
        loopstate = 0;
        break;
      }
    case 4: // MOVE SEND
      tcurrent = micros();
      if ((unsigned long)(tcurrent - tlastpuls) >= pulsdelay) {
        if (xPulsRemain > 0) {
          digitalWrite(InputBX, HIGH); // set pulse high
          xPulsRemain--;
        }
        if (yPulsRemain > 0) {
          digitalWrite(InputBY, HIGH);
          yPulsRemain--;
        }
        delayMicroseconds(pulsdelay); // loop only responsive to serial commands during "low" portion of pulses.  Not ideal, but not mission critical either
        digitalWrite(InputBX, LOW); // set pulse low
        digitalWrite(InputBY, LOW);
        if ((xPulsRemain == 0) && (yPulsRemain == 0)) {
          Serial.println("advance to L5");
          loopstate = 5; // advance to MOVE WAIT
        }

        tlastpuls = micros(); // pulse ended. update last pulse time
        
      // check for ASG mid-move send
      HLFBstatus = HLFBfilter(); // status is 0 when both HLFB are ASG
      if ( HLFBstatus == 0) {
        if (f_homing) {
          Serial.println("r2"); // report "home"
          f_homing = 0;
          loopstate = 5; // complete "move done" tasks
        }
        else {
          Serial.println("Unexpected obstruction");
        }
      }
      } // end timing check
      break;
    case 5: // MOVE WAIT
      // Check motor feedback, if both LOW, then move is done
      HLFBstatus = HLFBfilter(); // status is 0 when both HLFB report ASG
      if (HLFBstatus == 0) {
        //if((bool)digitalRead(HLFBX)) {
        f_LocKnown = 1;
        xloc = xtarget;
        yloc = ytarget;
        digitalWrite(EnableX, LOW); // motor disable
        digitalWrite(EnableY, LOW);
        if (f_autotrg) { // check if auto trigger flag enabled
          loopstate = 6; // advance to TRG SEND
          trgremain = ntrg; // queue ntrg pulses to send
          tlastpuls = millis(); // reset timer to force trgDelay before sending first trigger (allow stage to settle)
        }
        else {
          loopstate = 0; // return to WAITING
          Serial.println("r1"); // report motion complete
        }
      }
      break;
    case 6: // TRG SEND
      if ((trgremain > 0) || f_trgContinuous) {
        tcurrent = millis();
        if ((unsigned long)(tcurrent - tlastpuls) >= trgDelay) {
          trgremain--;
          digitalWrite(xducerTrg, HIGH); // set trg high
          delayMicroseconds(trgHiTm);  // loop only responsive to serial commands during "low" portion of pulses.  Not ideal, but not mission critical either
          digitalWrite(xducerTrg, LOW); // set trg low
          tlastpuls = millis(); // pulse ended. update last pulse time
        }
      }
      else { // triggers complete, return to WAITING
        loopstate = 0;
        Serial.println("r1"); // report motion complete
      }
      break;
    default: // WAITING
      break;
  }
}

void initHLFBfilter() {
  HLFBxAccum = 0;
  HLFBxAccum = ~HLFBxAccum; // fill bit accumulator with 1s (ie "HLFB Not Ready")
  
  HLFByAccum = 0;
  HLFByAccum = ~HLFByAccum; 
}

byte HLFBfilter() {
  // updates HLFB filter & returns a status byte
  // bitRead(status,0) is filtered HLFBx
  // bitRead(status,1) is filtered HLFBy
  // change filter duration by changing global variable HLFBxAccum data type
  
  HLFBxAccum = HLFBxAccum << 1;
  bitWrite(HLFBxAccum,0,digitalRead(HLFBX));
  
  HLFByAccum = HLFByAccum << 1;
  bitWrite(HLFByAccum,0,digitalRead(HLFBY));

  byte HLFBstatus = 0;
  if (HLFBxAccum != 0) { bitWrite(HLFBstatus,0,1); } // if bit history is not all 0s, write 1 to position 0 of output byte
  if (HLFByAccum != 0) { bitWrite(HLFBstatus,1,1); } // if bit history is not all 0s, write 1 to position 1 of output byte
  return HLFBstatus;
}

void serialEvent() { // executes @ end of every loop() if serial data waiting
  char gp = (char)Serial.read(); // read first availible character.  Should be command GROUP id
  switch (gp) { // Parse GROUP
    case 'm': { // MOVEMENT GROUP
        int cmd = (int)Serial.parseInt(SKIP_NONE);
        switch (cmd) {
          case 1: { // m01 - home axes
              loopstate = 1; // set loopstate to HOMING INIT
              break;
            }
          case 2: { // m02 - move to commanded location
              loopstate = 3; // set loopstate to MOVE INIT
              break;
            }
          case 3: { // m03 - set absolute x/y location target
              char ax = (char)Serial.read();
              int loc = (long)Serial.parseInt(SKIP_NONE);
              switch (ax) {
                case 'x':
                  xtarget = loc;
                  break;
                case 'y':
                  ytarget = loc;
                  break;
                default:
                  Serial.print(ax);
                  Serial.println(" Invalid Axis");
                  break;
              }
              break;
            }
          case 4: { // m04 - set relative x/y location target
              char ax = (char)Serial.read();
              int loc = (int)Serial.parseInt(SKIP_NONE);
              switch (ax) {
                case 'x':
                  xtarget += loc;
                  break;
                case 'y':
                  ytarget += loc;
                  break;
                default:
                  Serial.print(ax);
                  Serial.println(" Invalid Axis");
                  break;
              }
              break;
            }
          case 10: { // m10 - enable auto trigger out
              f_autotrg = 1;
              break;
            }
          case 11: { // m11 - disable auto trigger out
              f_autotrg = 0;
              break;
            }
          case 12: { // set # of triggers
              char delimit = (char)Serial.read();
              ntrg = (long)Serial.parseInt(SKIP_NONE);
              break;
            }
          case 13: { // set #ms delay between triggers
              char delimit = (char)Serial.read();
              trgDelay = (int)Serial.parseInt(SKIP_NONE);
              break;
            }
          default: {
              Serial.print(cmd);
              Serial.println(" Invalid M-Code");
            }
        } // end m-code cmd switch
        break;
      }
    case 'd': { // DIAGNOSTIC GROUP
        int cmd = (int)Serial.parseInt(SKIP_NONE);
        switch (cmd) {
          case 0: { //d00 - com test / version
              Serial.println(ver);
              break;
            }
          case 1: { // d01 - abort
              loopstate = 0;
              digitalWrite(EnableX, LOW); // disable motors
              digitalWrite(EnableY, LOW);
              break;
            }
          case 2: { // manual trigger
              trgremain = 1; // queue one trigger
              loopstate = 6;
              break;
            }
          case 3: { // continuous trigger (change m13 to choose interval)
              f_trgContinuous = 1;
              loopstate = 6;
              break;
            }
          case 4: { // stop continuous trigger
              f_trgContinuous = 0;
              loopstate = 0;
              break;
            }
          case 5: { // set trigger #ms "high" time
              char delimit = (char)Serial.read();
              trgHiTm = (int)Serial.parseInt(SKIP_NONE);
              break;
            }
          case 6: { // report loop status
              Serial.print("L");
              Serial.println(loopstate);
              break;
            }
          case 7: { // report current position
              if (f_LocKnown) {
                Serial.print("p");
                Serial.print(xloc);
                Serial.print(",");
                Serial.println(yloc);
              }
              else {
                Serial.println("p?,?");
              }
              break;
            }
          case 8: { // tmp for reading HLFBx
              Serial.println(digitalRead(HLFBX));
              break;
            }
          case 9: { // tmp for reading HLFBy
              Serial.println(digitalRead(HLFBY));
              break;
            }
          case 10: { // override home
              xloc = 0;
              xtarget = 0;
              yloc = 0;
              ytarget = 0;
              f_LocKnown = 1;
              break;
            }
          default: {
              Serial.print(cmd);
              Serial.println(" Invalid D-Code");
            }
        } // end d-code cmd switch
        break;
      }
    default: { // ERROR
        Serial.print(gp);
        Serial.println(" Invalid Command");
        break;
      }
  } // end group parse
}// end serialEvent()
