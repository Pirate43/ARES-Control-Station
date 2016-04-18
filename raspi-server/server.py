#!/usr/bin/env python
from time import sleep
import sys
import motors
import serialread
import network

import platform
WINENV = 'Windows' in platform.system()

if not WINENV:
    import RPi.GPIO as GPIO
    GPIO.setmode(GPIO.BOARD)  # Use board pin numbering
    GPIO.setup(7, GPIO.OUT)  # Setup GPIO Pin 7 to OUT


def log(sock, msg):
    sock_message = msg.encode()
    sock.send(sock_message)
    print(sock_message)

# socket settings
TCP_IP = '0.0.0.0'
TCP_PORT = 25555
packet_size = 4

print("Python version: " + sys.version)
if not WINENV:
    GPIO.output(7, True)  # Turn on GPIO pin 7 (the fourth one down from the right)

# begin network
net = network.Network(TCP_IP, TCP_PORT)
conn = net.connection
if not WINENV:
    GPIO.output(7, False)  # Turn off GPIO pin 7
while 1:

    if net.reinstantiate:
        net = network.Network(TCP_IP, TCP_PORT)
        conn = net.connection
    data = net.get_next_command()
    if not data:
        sleep(0.001)
        continue
    print("Received: ", data)

    try:
        # parse received data
        if data[0] == '^':  # FWD
            data = data[2:]
            if data and isinstance(int(data), int) and 0 < int(data) <= 5:
                log(conn, motors.go_fwd(int(data)))
            elif data == 0:
                log(conn, motors.halt_motors())
            else:
                data = ''
                log(conn, motors.go_fwd(data))

        elif data[0] == 'v':  # BWD
            data = data[2:]
            if data and isinstance(int(data), int) and 0 < int(data) <= 5:
                log(conn, motors.go_bwd(int(data)))
            elif data == 0:
                log(conn, motors.halt_motors())
            else:
                data = ''
                log(conn, motors.go_bwd(data))

        elif data[0] == '*':  # STOP
            log(conn, motors.halt_motors())
        elif data[0] == '>':  # TURN CW
            log(conn, motors.turn_cw())
        elif data[0] == '<':  # TURN CW
            log(conn, motors.turn_ccw())
        elif data[0] == 'u':  # RAISE BOT
            log(conn, motors.raise_bot())
        elif data[0] == 't':  # LOWER BOT
            log(conn, motors.lower_bot())
        elif data[0] == 'y':  # STOP ACTUATORS
            log(conn, motors.stop_actuators())
        elif data[0] == 'p':  # MINE FRONT DRUM
            log(conn, motors.mine_f())
        elif data[0] == 'o':  # MINE REAR DRUM
            log(conn, motors.mine_r())
        elif data[0] == 'l':  # DUMP FRONT DRUM
            log(conn, motors.dump_f())
        elif data[0] == 'k':  # DUMP REAR DRUM
            log(conn, motors.dump_r())
        elif data[0] == 'z':  # RAISE FRONT DRUM
            log(conn, motors.raise_f())
        elif data[0] == 'x':  # LOWER FRONT DRUM
            log(conn, motors.lower_f())
        elif data[0] == 'c':  # RAISE REAR DRUM
            log(conn, motors.raise_r())
        elif data[0] == 'f':  # LOWER REAR DRUM
            log(conn, motors.lower_r())
        elif data[0] == 'b':  # BATTERY Request
            log(conn, serialread.readbatt())
        elif data[0] == 's':  # WIFI SIGNAL STRENGTH Request
            log(conn, "SIG: 100%")
        elif data[0] == '-':  # QUIT Server gracefully
            break
        else:
            log(conn, " -Error: unimplemented command.")
    except Exception as e:
        log(conn, "Problem parsing data: " + str(e) + " ...data: " + data)
        continue

print("Terminating..." + str(1))
conn.close()
motors.end()
