#!/usr/bin/python           # This is client.py file

import socket               # Import socket module

host = socket.gethostname() # Get local machine name
port = 12345                # Reserve a port for your service.
s = socket.socket()         # Create a socket object

#loop for however many connections we want to make
#currently builds and destroys socket for every connection (TODO: improve performance)
for x in range(1):
    s.connect((host, port))
    print (s.recv(1024))
    s.close()                     # Close the socket when done