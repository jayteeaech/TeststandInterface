# Commands for xy positioning stage
Version 2.6, updated 2023-08-30

commands are case sensitive.  Use lowercase letters.

## Workflow
1) Power on motor power supply
2) Home axes
3) Move to center of measurement area to check alignment
4) Send triggers to set proper timing on oscilliscope
5) Set delay settling delay and delay between triggers 
6) move to first collection point
7) Enable auto trigger
8) Start data collection sequence


## M-Codes
Define motion actions.  Position targets are given in # of pulses unless otherwise specified.  Current hardware (as of 2023-08-30) uses motors set to 250 pulses / revolution and 3/8"-16 leadscrews.  This combination results in 157.480 Pulses / mm.

High Level Feed Back (HLFB) is LOW when All Systems Go (ASG), and HIGH when motors are disabled or in motion.

After motion (and trigger sequence, if enabled) is complete, Arduino sends "r1" - move complete

### Motion Control
- m01 - first power-on homing sequence.  Note that this can be used to manually set a (0,0) position that isn't motor's home.
- m02 - move to commanded location
- m03(x/y)## - set absolute (x/y) location command (#pulses as long integer)
- m04(x/y)## - set relative (x/y) location command

### Trigger Control
- m10 - enable auto trigger out
- m11 - disable auto trigger out
- m12:## - set # of triggers
- m13:## - set #ms delay between "Ready" signal on Trg In and sending transmit trigger on Trg In (default 100 ms)
- m14:## - set #ms delay between end of move and first trigger (Default 3000 ms)

## D-Codes
diagnostic codes for testing or adjusting misc. timings

- d00 - com test / version
- d01 - Move Cancel (*important note:* the actuator may not immediately stop when this command is issued)
- d02 - manual trigger
- d03 - continuous trigger (change m13 to choose interval)
- d04 - stop continuous trigger
- d05:## - set trigger #μs "high" time.
- d06 - return loop status (L#)
- d07 - return current position (p#,#).  Returns (p?,?) if location is unknown
- d08 - return HLFBx status
- d09 - return HLFBy status
- d10 - overrides "home"
- d11 - enable extra serial messages (good for diagnostics)
- d12 - disable extra serial messages

# Response Codes
Work in progress...
- r1: Move complete
- r2: Motors at home position (more accurately: motors reported ASG during a move send)

# Loop State Machine
Arduino main loop is structured as a state machine.  Issue command d06 to request loop status.
- 0 - waiting
- 1 - homing init
- 3 - move init
- 4 - move send
- 5 - move wait
- 6 - trg send

## State Machine Flow
**(0) Wait** - Set by d01, d04 commands, failed State (3).

**(1) Homing Init** - Set by m01 command. Enables motors and sets (0,0) position.  Continues to (5) Move Wait.

**(3) Move Init** - Set by m02 command.  Sets X/Y pulses and direction needed to move from current to target.  Continues to (4) Move Send if current location is known, sends error message and drops to (0) Wait otherwise.

**(4) Move Send** - Set at end of State (1) and (3). If pulse timer exceeds `pulsedelay`, set X/Y control pins high, wait for `pulsdelay` ms, and set control pins low.  Note that system will be unresponsive to serial during the high time due to `delay()`. Increments or Decrements location at each pulse. Continues to (5) Move Wait.

**(5) Move Wait** - Set at end of State (4).  Listens to HLFB inputs.  When both X/Y are *LOW*, continues to (6) Trigger Send if `autotrg` flag is set, (0) Wait otherwise.

**(6) Trigger Send** - Set by d02, d03 commands and State (5).  If pulse timer exceeds `trgDelay`, set trigger pin high, wait for `trgHiTm` ms, and set trigger pin low.  Continues to (0) when trigger sequence is complete.

# Changelog
v2.6 - 2023-08-30
- reduced motor Pulse Per Revolution setting from 1000 to 250 to address missing pulses

v2.5 - 2023-07-30
- Auto Trigger (m10) now waits for for Oscilliscope's Ready signal on trigger in port before sending next trigger

v2.4 - 2023-06-08
- major change with Homing behavior - ClearPath motors now home at first enable after power-on to address issues during movement

v2.3 - 2023-06-06
- added Delay between move and and trg to allow mechanical stage to settle
- fixed bug where commanded position was initially saved as an int instead of a long

v2.2 - 2022-06-27
- added HLFB filtering to address false "home" readings during motion

v2.1 - 2022-03-03
- added status d-codes (d06 "loop state" & d07 "current position")
- added "move done" report

v2.0 - 2022-02-25
- Initial Dev
