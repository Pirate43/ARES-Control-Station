from threading import Thread
import motors
sp = motors.sp


def readBatt():
    line = []
    sp.write(bytes("r,0,0;", 'UTF-8'))
    return str(sp.readline())
