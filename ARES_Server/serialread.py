from threading import Thread
import motors
sp = motors.sp


def readbatt():
    sp.write(bytes("r,0,0;", 'UTF-8'))
    return sp.readline().decode("utf-8")
