using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using SharpDX;
using SharpDX.DirectInput;
using System.Threading.Tasks;

namespace ControlStation {

    public partial class MainWindow : Form {


        Socket socket;


        public void gamepad() {
            var dInput = new DirectInput(); // Initialize DirectInput
            var joystickGuid = Guid.Empty;  // Find a Joystick Guid
            foreach (var deviceInstance in dInput.GetDevices(DeviceType.Gamepad,
                    DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;
            // If Joystick not found, log to console.
            if (joystickGuid == Guid.Empty) {
                log("Error: No joystick or Gamepad found.");
            }

            // Instantiate the joystick
            var joystick = new Joystick(dInput, joystickGuid);
            log("Found Gamepad with GUID: " + joystickGuid);
            log("Name: " + joystick.Properties.InstanceName);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                log("Effect available " + effectInfo.Name);

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

            bool sent = false;
            while (true) {
                joystick.Poll();
                var datas = joystick.GetBufferedData();
                foreach (var state in datas) {
                    String offset = state.Offset.ToString();
                    int value = int.Parse(state.Value.ToString());
                    log(offset + " " + value);

                    // end gamepad on share button
                    if (offset == "Buttons8" && value > 64) {
                        log("Share button pressed. Gamepad stopped.");
                        return;
                    }


                    if (offset == "Y" && value == 0 && !sent) { 
                        send("^");
                        log("Sending ^");
                        sent = !sent;
                    }

                    if (offset == "Y" && value > 0 && sent) {
                        send("*");
                        log("Sending *");
                        sent = !sent;
                    }
                }
            }
        }

        // start gamepad in a separate task
        private void gamepadButton_Click(object sender, EventArgs e) {
            Task t = Task.Run(() => {
                gamepad();
            });
        }

        public MainWindow() {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            textboxIP.Text = "raspberrypi";
            console.Text = GetTimestamp(DateTime.Now) + " initialized.";
            
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // exit app
        {
            Application.Exit();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) // exit app
        {
            Application.Exit();
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            log("Connecting to " + textboxIP.Text + "..");
            batteryBar.PerformStep();
            try {
                socket.Connect(textboxIP.Text, 25555);
                log("connected!");
                textboxIP.Enabled = false;
                textboxIP.BackColor = System.Drawing.Color.Green;
                buttonConnect.Enabled = false;
                disconnectButton.Enabled = true;
                disconnectButton.BackColor = System.Drawing.Color.Transparent;
                enableCommands();
            }
            catch (Exception ex) {
                log("Problem connecting: " + ex.Message);
                return;
            }
        }

        private void saveConsoleLogsToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            // save console contents to log file
            saveFileDialog1.FileName = GetFilePathTimestamp(DateTime.Now) + "_ARES.log";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) // save console to log file
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter(saveFileDialog1.FileName);
            //log("Created file " + saveFileDialog1.FileName);

            // write console content to text writer
            tw.Write(console.Text);

            // close the stream
            tw.Close();

            //log("Saved to " + saveFileDialog1.FileName);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // show about dialog
        {
            AboutBox a = new AboutBox();
            a.Show();
        }

        private void disconnectButton_Click(object sender, EventArgs e) {
            try {
                socket.Close();
            }
            catch (Exception ex) {
                log("Error disconnecting: " + ex.Message);
                return;
            }
            log("Successfully disconnected.");
            textboxIP.Enabled = true;
            textboxIP.BackColor = System.Drawing.Color.White;
            buttonConnect.Enabled = true;
            disconnectButton.Enabled = false;
            disconnectButton.BackColor = System.Drawing.Color.Silver;
        }

        //################      HELPER FUNCTIONS      ##################\\
        public void log(String s) {
            console.AppendText("\r\n" + GetTimestamp(DateTime.Now) + " " + s + "");
        }
        public static String GetTimestamp(DateTime value) {
            return value.ToString("HH:mm:ss");
        }
        public static String GetFilePathTimestamp(DateTime value) {
            return value.ToString("yyyyMMdd--HHmmss");
        }
        public void send(String s) {
            socket.Send(System.Text.Encoding.UTF8.GetBytes(s));
        }
        private void btn_MouseDown(object sender, MouseEventArgs e) {
            var btn = (FontAwesomeIcons.IconButton)sender;
            btn.BackColor = System.Drawing.Color.Gold;
            switch (btn.Name) {
                case "goForward":
                    send("^");
                    log("Sending ^");
                    break;
                case "goBackward":
                    send("v");
                    log("Sending v");
                    break;
                case "turnCW":
                    send(">");
                    log("Sending >");
                    break;
                case "turnCCW":
                    send("<");
                    log("Sending <");
                    break;
                case "lowerMining":
                    send("L");
                    log("Sending L");
                    break;
                case "doMining":
                    send("M");
                    log("Sending M");
                    break;
                case "raiseMining":
                    send("R");
                    log("Sending R");
                    break;
                case "doDump":
                    send("D");
                    log("Sending D");
                    break;
                case "disconnectButton":
                    break;
                default:
                    break;
            }
        }
        private void btn_MouseUp(object sender, MouseEventArgs e) {
            var btn = (FontAwesomeIcons.IconButton)sender;
            btn.BackColor = System.Drawing.Color.Transparent;
            if (btn.Name == "disconnectButton") {
                btn.BackColor = System.Drawing.Color.Silver;
                disableCommands();
            }
            else send("*");
        }

        private void enableCommands() {
            transportGroup.Enabled = true;
            miningGroup.Enabled = true;
        }
        private void disableCommands() {
            transportGroup.Enabled = false;
            miningGroup.Enabled = false;
        }

        
    }
}
