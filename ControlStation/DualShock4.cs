using SharpDX.DirectInput;
using System;

namespace ControlStation {
    class DualShock4 {

        MainWindow mw;
        int rStickX = 0;
        int rStickY = 0;
        int rTrigger = 0;
        int lTrigger = 0;
        
        // constructor
        public DualShock4(MainWindow mainWind) {
            this.mw = mainWind;
        }

        // turn button states into booleans.
        private bool normalizeButton(int value) {
            if (value > 64) return true;
            else return false;
        }

        // turn stick state into level -5 to 5
        private int normalizeStick(int value) {
            if (value > 65000) return -5;
            else if (value <= 65000 && value > 55000) return -4;
            else if (value <= 55000 && value > 45000) return -3;
            else if (value <= 45000 && value > 40000) return -2;
            else if (value <= 40000 && value > 35000) return -1;
            else if (value <= 40000 && value > 23000) return 0;
            else if (value <= 23000 && value > 18000) return 1;
            else if (value <= 18000 && value > 13000) return 2;
            else if (value <= 13000 && value > 8000) return 3;
            else if (value <= 8000 && value > 3000) return 4;
            else if (value <= 3000) return 5;
            else throw new Exception("bad stick value (DualShock4.cs)");
        }

        private int normalizeTrigger(int value) {
            if (value > 60000) return 5;
            else if (value <= 60000 && value > 50000) return 4;
            else if (value <= 50000 && value > 40000) return 3;
            else if (value <= 40000 && value > 30000) return 2;
            else if (value <= 30000 && value > 20000) return 1;
            else if (value <= 20000) return 0;
            else throw new Exception("bad trigger value (DualShock4.cs)");
        }

        public void gamepad() {
            var dInput = new DirectInput(); // Initialize DirectInput
            var joystickGuid = Guid.Empty;  // Find a Joystick Guid
            foreach (var deviceInstance in dInput.GetDevices(DeviceType.Gamepad,
                    DeviceEnumerationFlags.AllDevices)) {
                mw.log("deviceInstance " + deviceInstance.InstanceName);
                joystickGuid = deviceInstance.InstanceGuid;
            }
            // If Joystick not found, log to console.
            if (joystickGuid == Guid.Empty) {
                mw.log("Error: No joystick or Gamepad found.");
                return;
            }

            // Instantiate the joystick
            var joystick = new Joystick(dInput, joystickGuid);
            mw.log("Found Gamepad with GUID: " + joystickGuid);
            mw.log("Name: " + joystick.Properties.InstanceName);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                mw.log("Effect available " + effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            // Set deadzones to 10%
            joystick.Properties.DeadZone = 1000;


            /// Button Mappings:::
            /// ============================
            /// - Buttons0 = ■
            /// - Buttons1 = x
            /// - Buttons2 = ●
            /// - Buttons3 = ▲
            /// - Buttons4 = Left Bumper
            /// - Buttons5 = Right Bumper
            /// - Buttons6 = Left Trigger
            /// - Buttons7 = Right Trigger
            /// - Buttons8 = Share
            /// - Buttons9 = Options
            /// - Buttons10 = Left Stick
            /// - Buttons11 = Right Stick
            /// - Buttons12 = PS Button
            /// 
            /// - Right Stick: 
            ///         (Y)                 (X)
            ///     0     all up        0     all left
            ///     32767 neutral       32767 neutral
            ///     65535 all down      65535 all right
            ///     
            /// - DPAD (PointOfViewControllers0) ::
            ///     0 = up
            ///     18000 = down
            ///     27000 = left
            ///     9000 = right
            ///     -1 = release
            ///
            
            while (true) {
                joystick.Poll();
                var datas = joystick.GetBufferedData();
                foreach (var state in datas) {
                    String offset = state.Offset.ToString();
                    int value = int.Parse(state.Value.ToString());
                    //mw.log(offset + " " + value); //LOG EVERYTHING

                    if (offset == "X") { // left stick X
                        value = normalizeStick(value);
                        if (value != rStickX) {
                            mw.log(offset + " " + value);
                            rStickX = value;
                        }
                    }
                    else if (offset == "Y") {
                        value = normalizeStick(value); // left stick Y
                        if (value != rStickY) {
                            mw.log(offset + " " + value);
                            rStickY = value;
                        }
                    }
                    else if (offset == "RotationY") { // right trigger
                        value = normalizeTrigger(value);
                        if(value != rTrigger) {
                            mw.log("Right Trigger " + value);
                            rTrigger = value;
                            mw.send("^ " + rTrigger); 
                        }
                    }
                    else if (offset == "RotationX") { // left trigger
                        value = normalizeTrigger(value);
                        if (value != lTrigger) {
                            mw.log("Left Trigger " + value);
                            lTrigger = value;
                        }
                    }
                    else if (offset == "Buttons0") { // square
                        mw.log("■ button: " + normalizeButton(value));
                    }
                    else if (offset == "Buttons1") { // X
                        mw.log("X button: " + normalizeButton(value));
                    }
                    else if (offset == "Buttons2") { // O
                        mw.log("O button: " + normalizeButton(value));
                    }
                    else if (offset == "Buttons3") { // triangle
                        mw.log("▲ button: " + normalizeButton(value));
                    }
                    // TODO : L1 / R1 + DPAD
                    else if (offset == "Buttons8" && value > 64) { 
                        // end gamepad on share button
                        mw.log("Share button pressed. Gamepad stopped.");
                        return;
                    }







                    /*
                    if (offset == "Y" && value == 0 && !sent) {
                        mw.send("^");
                        mw.log("Sending ^");
                        sent = !sent;
                    }

                    if (offset == "Y" && value > 0 && sent) {
                        mw.send("*");
                        mw.log("Sending *");
                        sent = !sent;
                    }*/
                }
            }
        }
    }
}
