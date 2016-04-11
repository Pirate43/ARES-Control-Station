import motors
WINENV = motors.WINENV
if not WINENV:
    sp = motors.sp


def readbatt():
    if not WINENV:
        sp.write(bytes("r,0,0;", 'UTF-8'))
        return sp.readline().decode("utf-8")
    else:
        return "BATT 13.4"
