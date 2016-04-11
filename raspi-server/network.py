import socket
from socket import error as socket_error
import errno
import threading
from time import sleep

BUFFER_SIZE = 16


class Network:
    exit_flag = False
    incoming = ""
    reinstantiate = False

    def __init__(self, sock_ip, sock_port):
        self.ip = sock_ip
        self.port = sock_port
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.bind((self.ip, self.port))
        self.sock.listen(1)
        print("Listening on ", self.ip, ":", self.port, "...")
        self.connection, self.addr = self.sock.accept()
        print("Connected!")
        t = threading.Thread(target=self.socket_reader, args=())
        t.start()

    def socket_reader(self):  # run in separate thread
        while not self.exit_flag:
            try:
                data = self.connection.recv(BUFFER_SIZE)
                self.incoming += data.decode()
            except socket_error as e:
                if e.errno == errno.ECONNRESET:
                    print("Client disconnected unexpectedly.")
                else:
                    print("Unknown error: ", e)
                self.reinstantiate = True
                self.sock.close()
                break

    def get_next_command(self):
        if len(self.incoming) > 0:
            command = self.incoming[:self.incoming.find(";")]
            self.incoming = self.incoming[self.incoming.find(";")+1:]
            return command
        else:
            return False
