import socket               

s = socket.socket()         
host = socket.gethostname() 
port = 12342              
s.bind(("", port))        

s.listen(5)                 
while True:
    c, addr = s.accept()     
    print ('address', addr)
    c.send("12345")
    c.close()                
