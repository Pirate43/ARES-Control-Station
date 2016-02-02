from threading import Thread
import motors
sp = motors.sp


def readBatt():
    line = []
    sp.write(bytes("r,0,0;", 'UTF-8'))
    line = str(sp.readline())
    if line[0] == 'r':
        line = sp.readline()
    return line
