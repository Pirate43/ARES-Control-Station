# ARES-Control-Station

This is the code that will power Florida Institute of Technology 's entry into NASA's Robotic Mining Competition for 2016. The GUI is made with C# and Windows Forms. It supports Playstation 4 controller input. 

The robot's on-board raspberry pi will run a python script that takes in network communications from the GUI and translates them into commands to feed the arduino.

The arduino is intended to be a passive device accepting data and using it to spin motors, or taking sensor data and passing it up to the raspberry pi for either processing or off-loading back to the control station GUI.
