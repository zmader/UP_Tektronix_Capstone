#script to spawn 2 threads, run rsa_dpx in one and clientdemo in the other
#intended to be executed from Hololens/within Unity
#Author: Gabby Marshak
from time import sleep, perf_counter
from threading import Thread

def server():
    exec(open("rsa_dpx.py").read())

def client():
    exec(open("clientdemo.py").read())

#create threads
t1 = Thread(target=server)
t2 = Thread(target=client)

#start threads
t1.start()
t2.start()

#join threads
t1.join()
t2.join()