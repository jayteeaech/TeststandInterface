# Commands for xy positioning stage
Version 2.2, updated 2022-06-27

commands are case sensitive.  Use lowercase letters.

## M-Codes
Define motion actions.  Position targets are given in # of pulses unless otherwise specified.  Current hardware (as of 2022-03-03) uses motors set to 1000 pulses / revolution and 3/8"-16 leadscrews.  This combination results in 629.921 Pulses / mm.

High Level Feed Back (HLFB) is LOW when All Systems Go (ASG), and HIGH when motors are disabled or in motion.

After motion (and trigger sequence, if enabled) is complete, Arduino sends "r1" - move complete

### Motion Control
- m01 - Home axes
- m02 - move to commanded location
- m03(x/y)## - set absolute (x/y) location command (#pulses as long integer)
- m04(x/y)## - set relative (x/y) location command

### Trigger Control
- m10 - enable auto trigger out
- m11 - disable auto trigger out
- m12:## - set # of triggers
- m13:## - set #ms delay between triggers

## D-Codes
diagnostic codes for testing or adjusting misc. timings

- d00 - com test / version
- d01 - soft reset (cancels loop, disables motors)
- d02 - manual trigger
- d03 - continuous trigger (change m13 to choose interval)
- d04 - stop continuous trigger
- d05:## - set trigger #ms "high" time.
- d06 - return loop status (L#)
- d07 - return current position (p#,#).  Returns (p?,?) if location is unknown

# Response Codes
Work in progress...
- r1: Move complete
- r2: Motors at home position (more accurately: motors reported ASG during a move send)

# Loop State Machine
Arduino main loop is structured as a state machine.  Issue command d06 to request loop status.
- 0 - waiting
- 1 - homing init
- ~~2 - homing wait~~ (unused.)
- 3 - move init
- 4 - move send
- 5 - move wait
- 6 - trg send

## State Machine Flow
**(0) Wait** - Set by d01 command, failed State (3).

**(1) Homing Init** - Set by m01, d04 commands. Sets target to (0,0), sets X/Y direction negative, sets X/Y # pulses to max range.  Continues to (4) Move Send.

**(3) Move Init** - Set by m02 command.  Sets X/Y pulses and direction needed to move from current to target.  Continues to (4) Move Send if current location is known, sends error message and drops to (0) Wait otherwise.

**(4) Move Send** - Set at end of State (1) and (3). If pulse timer exceeds `pulsedelay`, set X/Y control pins high, wait for `pulsdelay` ms, and set control pins low.  Note that system will be unresponsive to serial during the high time due to `delay()`. Continues to (5) Move Wait.

**(5) Move Wait** - Set at end of State 4.  Listens to HLFB inputs.  When both X/Y are *LOW*, continues to (6) Trigger Send if `autotrg` flag is set, (0) Wait otherwise.

**(6) Trigger Send** - Set by d02, d03 commands and State (5).  If pulse timer exceeds `trgDelay`, set trigger pin high, wait for `trgHiTm` ms, and set trigger pin low.  Continues to (0) when trigger sequence is complete.

# Changelog
v2.2 - 2022-06-27
- added HLFB filtering to address false "home" readings during motion

v2.1 - 2022-03-03
- added status d-codes (d06 "loop state" & d07 "current position")
- added "move done" report

v2.0 - 2022-02-25
- Initial Dev
