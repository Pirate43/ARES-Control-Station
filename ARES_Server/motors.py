import serial
# motor values
# 125~185 - reverse
# 186~190 - neutral
# 191~254 - forward

LEVEL1 = 200
LEVEL2 = 210
LEVEL3 = 220
LEVEL4 = 235
LEVEL5 = 254

# Wiring constants (these should be PWM pins on the Arduino)
PIN_FR = 5 #Fronts might be backwards
PIN_FL = 7
PIN_RR = 10 #Rears might be backwards
PIN_RL = 8
PIN_ACT_R = 0
PIN_ACT_L = 0

# Open our serial connection
sp = serial.Serial("/dev/ttyAMA0", baudrate=9600, timeout=2)

def go_fwd(speed):  # spin all 4 motors forward
    if not speed:
        sp.write(bytes("a," + str(PIN_FR) + ",200;", 'UTF-8'))
        sp.write(bytes("a," + str(PIN_FL) + ",200;", 'UTF-8'))
        sp.write(bytes("a," + str(PIN_RR) + ",200;", 'UTF-8'))
        sp.write(bytes("a," + str(PIN_RL) + ",200;", 'UTF-8'))
        return "GO FWD - (no speed set)"
    else:
        sp.write(bytes("a,"+str(PIN_FR)+","+str(level2motor(speed))+";",'UTF-8'))
        sp.write(bytes("a,"+str(PIN_FL)+","+str(level2motor(speed))+";",'UTF-8'))
        sp.write(bytes("a,"+str(PIN_RR)+","+str(level2motor(speed))+";",'UTF-8'))
        sp.write(bytes("a,"+str(PIN_RL)+","+str(level2motor(speed))+";",'UTF-8'))
        return "GO FWD " + str(level2motor(speed))


def go_bwd(speed):  # spin all 4 motors backward
    if not speed:
        return "GO BWD - (no speed set)"
    else:
        return "GO BWD " + str(level2motor(speed))


def halt_motors(): # stop all 4 motors
    sp.write(bytes("a," + str(PIN_FR) + ",190;", 'UTF-8'))
    sp.write(bytes("a," + str(PIN_FL) + ",190;", 'UTF-8'))
    sp.write(bytes("a," + str(PIN_RR) + ",190;", 'UTF-8'))
    sp.write(bytes("a," + str(PIN_RL) + ",190;", 'UTF-8'))
    return "STOP"


def turn_cw():  # single set speed
    # spin *R motors BWD
    # spin *L motors FWD
    return "TURN CW"


def turn_ccw():  # single set speed
    # spin *R motors FWD
    # spin *L motors BWD
    return "TURN CCW"


def raise_bot(): # RETRACT both actuators
    return "RAISE CHASSIS"


def lower_bot(): # EXTEND both actuators
    return "LOWER CHASSIS"


def level2motor(level):
    levels = {
        -5: 125,  # LEVEL -5
        -4: 135,  # LEVEL -4
        -3: 150,  # LEVEL -3
        -2: 170,  # LEVEL -2
        -1: 180,  # LEVEL -1
        0: 190,  # NEUTRAL / LEVEL 0
        1: 200,  # LEVEL 1
        2: 210,  # LEVEL 2
        3: 220,  # LEVEL 3
        4: 235,  # LEVEL 4
        5: 254  # LEVEL 5
    }
    return int(levels[level])
