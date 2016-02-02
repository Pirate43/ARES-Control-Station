from threading import Thread
import motors
sp = motors.sp


def readbatt():
    line = []
    sp.write(bytes("r,0,0;", 'UTF-8'))
    line = str(sp.readline())
    return line
