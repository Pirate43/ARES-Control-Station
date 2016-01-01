# ARES-Control-Station

*NOTE:* **Ensure the Arduino is outputting 190 on the port of the Talon speed controller prior to running the power supply.** Example: send "a,11,190;" where 11 is where the Talon is plugged in, 190 is the PWM value we're setting it to. 

This is the code that will power Florida Institute of Technology 's entry into NASA's Robotic Mining Competition for 2016. The GUI is made with C# and Windows Forms. It supports Playstation 4 controller input. 

The robot's on-board raspberry pi will run a python script that takes in network communications from the GUI and translates them into commands to feed the arduino.

The arduino is intended to be a passive device accepting data and using it to spin motors, or taking sensor data and passing it up to the raspberry pi for either processing or off-loading back to the control station GUI.


![demo of it in action](http://p43.xyz/x/2015-10-16_21-10-59.gif)
