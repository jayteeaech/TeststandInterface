# Commands for xy positioning stage
Version 2.0, updated 2022-02-25

commands are case sensitive.  Use lowercase letters.

## M-Codes
define motion actions

### Motion Control
- m01 - Home axes
- m02 - move to commanded location
- m03(x/y)## - set absolute (x/y) location command (#mm as integer)
- m04(x/y)## - set relative (x/y) location command

### Trigger Control
- m10 - enable auto trigger out
- m11 - disable auto trigger out
- m12:## - set # of triggers
- m13:## - set #ms delay between triggers

## D-Codes
diagnostic codes for testing or adjusting misc. timings

- d00 - com test / version
- d01 - abort (cancels loop, disables motors)
- d02 - manual trigger
- d03 - continuous trigger (change m13 to choose interval)
- d04 - stop continuous trigger
- d05:## - set trigger #ms "high" time

# Loop State Machine
Right now this information is hidden on the arduino.  I eventually need to add a d-code that allows the arduino to report it's status
- 0 - waiting
- 1 - homing init
- ~~2 - homing wait~~ (depricated)
- 3 - move init
- 4 - move send
- 5 - move wait
- 6 - trg send

# Changelog
v1.0 - 2022-02-25 - Initial Dev
