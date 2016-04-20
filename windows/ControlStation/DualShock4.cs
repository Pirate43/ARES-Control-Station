using System;
using SharpDX.DirectInput;

namespace ControlStation {
    class DualShock4 {

        readonly MainWindow _mw;
        int _rStickX;
        int _rStickY;
        int _rTrigger;
        int _lTrigger;
        private bool _forward;
        private bool _reverse;
        
        // constructor
        public DualShock4(MainWindow mainWind) {
            _mw = mainWind;
        }

        // turn button states into booleans.
        private static bool normalizeButton(int value) {
            return value > 64;
        }

        // turn stick state into level -5 to 5
        private int normalizeStick(int value)
        {
            if (value > 65000) return -5;
            if (value <= 65000 && value > 55000) return -4;
            if (value <= 55000 && value > 45000) return -3;
            if (value <= 45000 && value > 40000) return -2;
            if (value <= 40000 && value > 35000) return -1;
            if (value <= 40000 && value > 23000) return 0;
            if (value <= 23000 && value > 18000) return 1;
            if (value <= 18000 && value > 13000) return 2;
            if (value <= 13000 && value > 8000) return 3;
            if (value <= 8000 && value > 3000) return 4;
            if (value <= 3000) return 5;
            throw new Exception("bad stick value (DualShock4.cs)");
        }

        private int normalizeTrigger(int value)
        {
            if (value > 60000) return 5;
            if (value <= 60000 && value > 50000) return 4;
            if (value <= 50000 && value > 40000) return 3;
            if (value <= 40000 && value > 30000) return 2;
            if (value <= 30000 && value > 20000) return 1;
            if (value <= 20000) return 0;
            throw new Exception("bad trigger value (DualShock4.cs)");
        }

        public void gamepad() {
            var dInput = new DirectInput(); // Initialize DirectInput
            var joystickGuid = Guid.Empty;  // Find a Joystick Guid
            foreach (var deviceInstance in dInput.GetDevices(DeviceType.Gamepad,
                    DeviceEnumerationFlags.AllDevices)) {
                _mw.log("deviceInstance " + deviceInstance.InstanceName);
                joystickGuid = deviceInstance.InstanceGuid;
            }
            // If Joystick not found, log to console.
            if (joystickGuid == Guid.Empty) {
                _mw.log("Error: No joystick or Gamepad found.");
                return;
            }

            // Instantiate the joystick
            var joystick = new Joystick(dInput, joystickGuid);
            _mw.log("Found Gamepad with GUID: " + joystickGuid);
            _mw.log("Name: " + joystick.Properties.InstanceName);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                _mw.log("Effect available " + effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();

            // Set deadzones to 10%
            joystick.Properties.DeadZone = 1000;

            
            // Button Mappings:::
            // ============================
            // - Buttons0 = ■
            // - Buttons1 = x
            // - Buttons2 = ●
            // - Buttons3 = ▲
            // - Buttons4 = Left Bumper
            // - Buttons5 = Right Bumper
            // - Buttons6 = Left Trigger
            // - Buttons7 = Right Trigger
            // - Buttons8 = Share
            // - Buttons9 = Options
            // - Buttons10 = Left Stick
            // - Buttons11 = Right Stick
            // - Buttons12 = PS Button
            // 
            // - Right Stick: 
            //         (Y)                 (X)
            //     0     all up        0     all left
            //     32767 neutral       32767 neutral
            //     65535 all down      65535 all right
            //     
            // - DPAD (PointOfViewControllers0) ::
            //     0 = up
            //     18000 = down
            //     27000 = left
            //     9000 = right
            //     -1 = release
            //
            
            while (true) {
                joystick.Poll();
                var datas = joystick.GetBufferedData();
                foreach (var state in datas) {
                    string offset = state.Offset.ToString();
                    int value = int.Parse(state.Value.ToString());
                    //_mw.log(offset + " " + value); //LOG EVERYTHING

                    if (offset == "X") { // left stick X
                        value = normalizeStick(value);
                        if (value != _rStickX) {
                            _mw.log(offset + " " + value);
                            _rStickX = value;
                        }
                    }
                    else if (offset == "Y") {
                        value = normalizeStick(value); // left stick Y
                        if (value != _rStickY) {
                            _mw.log(offset + " " + value);
                            _rStickY = value;
                        }
                    }
                    else if (offset == "RotationY") { // right trigger
                        value = normalizeTrigger(value);
                        if (value != _rTrigger && !_reverse) {
                            _mw.log("Right Trigger " + value);
                            _rTrigger = value;
                            _mw.send(value == 0 ? "*" : "^ " + _rTrigger);
                            if (value != 0) _mw.btnFakePress(_mw.goForward);
                            else _mw.btnFakeRelease(_mw.goForward);
                            _reverse = false;
                            _forward = true;
                        }
                    }
                    else if (offset == "RotationX") { // left trigger
                        value = normalizeTrigger(value);
                        if (value != _lTrigger && !_forward) {
                            _mw.log("Left Trigger " + value);
                            _lTrigger = value;
                            _mw.send(value==0?"*":"v " + _lTrigger);
                            if (value != 0) _mw.btnFakePress(_mw.goBackward);
                            else _mw.btnFakeRelease(_mw.goBackward);
                            _reverse = true;
                            _forward = false;
                        }
                    }
                    else if(offset == "Buttons4") { // LEFT BUMPER
                        _mw.log("LB " + normalizeButton(value));
                        if (normalizeButton(value)) {
                            _mw.send("<");
                            _mw.btnFakePress(_mw.turnCCW);
                        }
                        else {
                            _mw.send("*");
                            _mw.btnFakeRelease(_mw.turnCCW);
                        }
                    }
                    else if (offset == "Buttons5") { // RIGHT BUMPER
                        _mw.log("RB " + normalizeButton(value));
                        if (normalizeButton(value)) {
                            _mw.send(">");
                            _mw.btnFakePress(_mw.turnCW);
                        }
                        else {
                            _mw.send("*");
                            _mw.btnFakeRelease(_mw.turnCW);
                        }
                    }
                    else if (offset == "Buttons0") { // square
                        _mw.log("■ button: " + normalizeButton(value));
                    }
                    else if (offset == "Buttons1") { // X
                        if (normalizeButton(value)) {
                            _mw.send("t");
                            _mw.btnFakePress(_mw.lowerBot);
                        }
                        else {
                            _mw.send("y");
                            _mw.btnFakeRelease(_mw.raiseBot);
                        }
                        _mw.log("X button: " + normalizeButton(value));
                    }
                    else if (offset == "Buttons2") { // O
                        _mw.log("O button: " + normalizeButton(value));
                        _mw.send("*");
                    }
                    else if (offset == "Buttons3") { // triangle
                        if (normalizeButton(value)) {
                            _mw.send("u");
                            _mw.btnFakePress(_mw.raiseBot);
                        }
                        else {
                            _mw.send("y");
                            _mw.btnFakeRelease(_mw.raiseBot);
                        }
                        _mw.log("▲ button: " + normalizeButton(value));
                    }
                    // TODO: SQUARE AND DPAD
                    // TODO: RIGHT STICK


                    else if (offset == "Buttons8" && value > 64) { 
                        // end gamepad on share button
                        _mw.log("Share button pressed. Gamepad stopped.");
                        return;
                    }
                }
            }
        }
    }
}
