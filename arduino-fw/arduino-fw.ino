#include <Servo.h>
Servo conveyor;
Servo smallTestServo;
String inputString;
boolean stringComplete = false;

void setup() {
    pinMode(5, OUTPUT);  // FR
    pinMode(7, OUTPUT);  // FL
    pinMode(8, OUTPUT);  // RR
    pinMode(10, OUTPUT); // RL
    pinMode(A0, INPUT);  // BATT
    pinMode(2, OUTPUT);  // R ACTUATOR SPEED
    pinMode(22, OUTPUT); // R ACTUATOR DIR
    pinMode(3, OUTPUT);  // L ACTUATOR SPEED
    pinMode(23, OUTPUT); // L ACTUATOR DIR
    analogWrite(5, 187);
    analogWrite(7, 187);
    analogWrite(8, 187);
    analogWrite(10, 187);
    Serial.begin(115200);
    //conveyor.attach(8);
    //conveyor.write(86);
    //smallTestServo.attach(10);
    inputString.reserve(32);
    Serial.println("Hi!");
}

void loop() {
    if (Serial.available() > 0) {
        inputString = Serial.readStringUntil(';');
        stringComplete = true;
    }
    
    if (stringComplete) {
        //Serial.println(inputString);
        int i1 = inputString.indexOf(',');
        int i2 = inputString.lastIndexOf(',');
        char cmd = inputString.charAt(0);
        int gpio = inputString.substring(i1 + 1, i2).toInt();
        //String value = inputString.substring(i2+1, inputString.length());
        //Serial.println(value);
        int value = inputString.substring(i2 + 1, inputString.length()).toInt();
        /*Serial.print("CMD:  ");
        Serial.println(cmd);
        Serial.print("GPIO: ");
        Serial.println(gpio);
        Serial.print("VAL:  ");
        Serial.println(value);
        Serial.print("\n");*/
        switch (cmd) {
            case 'a': { // analogWrite
                analogWrite(gpio, value); }
                break;
            case 's': {
                if (gpio == 8)
                    conveyor.write(value);
                if (gpio == 10)
                    smallTestServo.write(value); }
                break;
            case 'r': { // READ BATT VOLTAGE
                Serial.print("BATT: ");
                float batt = analogRead(gpio) * (5.0 / 1023.0);
                batt = batt / ( 910 / (float) (1600 + 910) );
                Serial.println(batt); }
                break;
            case 'u': { // RETRACT ACTUATORS
                digitalWrite(22, HIGH);
                digitalWrite(23, HIGH);
                analogWrite(2, 60);
                analogWrite(3, 60); }
                break;
            case 'y': { // STOP ACTUATORS
                digitalWrite(22, HIGH);
                digitalWrite(23, HIGH);
                analogWrite(2, 250);
                analogWrite(3, 250); }
                break;
            case 't': { // EXTEND ACTUATORS
                digitalWrite(22, LOW);
                digitalWrite(23, LOW);
                analogWrite(2, 240);
                analogWrite(3, 240); }
                break;
        }
        stringComplete = false;
    }

}

