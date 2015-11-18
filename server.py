#!/usr/bin/env python
import socket
# import serial

# motor values
# 125~185 - reverse
# 186~190 - neutral
# 191~254 - forward

# LEVEL 1 = 200
# LEVEL 2 = 210
# LEVEL 3 = 220
# LEVEL 4 = 235
# LEVEL 5 = 254
def level2motor(level):
    """
    :type level: int
    """
    levels = {
        0: 190,
        1: 200,
        2: 210,
        3: 220,
        4: 235,
        5: 254
    }
    return int(levels[level])

# socket settings
TCP_IP = '0.0.0.0'
TCP_PORT = 25555
BUFFER_SIZE = 1024
packet_size = 4

# open our serial connection
# sp = serial.Serial("/dev/ttyAMA0", baudrate=9600, timeout=2)

# create and ready our socket with its settings
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((TCP_IP, TCP_PORT))
s.listen(1)
print "Awaiting connection..."
conn, addr = s.accept()
print "Connection address: ", addr
while 1:

    # while len(data) < packet_size:
    #     d = client_socket.recv(1024)
    #     if not d:
    #         client_socket.close()
    #         client_socket = connect(addr)
    #     else:
    #         data += d
    # packet, data = data[:packet_size], data[packet_size:]

    data = conn.recv(BUFFER_SIZE)

    # no data? there was a disconnection. Await for new connection
    if not data:
        print "Client disconnected.\nAwaiting connection..."
        conn, addr = s.accept()
        print "Connection address: ", addr
        continue

    # if a dash character is received, quit the application
    if data == '-':
        break

    print "Received: ", data
    conn.send("Robot: " + data)

    # parse received data
    if data[0] == "^":
        data = data[2:]
        value = level2motor(int(data))
        ardcmd = "a,11," + str(value) + ";"
        print "FWD  ", ardcmd
        # sp.write(ardcmd)
    elif data == "*":
        ardcmd = "a,11,190;"
        print "STOP ", ardcmd
        # sp.write(ardcmd)
    elif data == "v":
        ardcmd = "a,11,178;"
        print "BACK ", ardcmd
        # sp.write(ardcmd)

print "Terminating..."
conn.close()
