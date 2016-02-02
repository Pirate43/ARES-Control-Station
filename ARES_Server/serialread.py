from threading import Thread
import motors
sp = motors.sp


def readBatt():
    line = []
    sp.write(bytes("r", 'UTF-8'))
    return sp.readline()
