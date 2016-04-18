using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Timers;

namespace ControlStation {

    public partial class MainWindow : Form {
        
        private class IPItem {
            public string Name { get; set; }
            public string Ip { get; set; }
            public IPItem(string name, string ip) { Name = name; Ip = ip; }
            public override string ToString() {
                return Ip;
            }
        }

        Socket socket;
        DualShock4 ds4;
        Byte[] incomingBuf = new Byte[16];
        Task recv;
        bool doDisconnect = false;
        
        // start gamepad in a separate task
        private void gamepadButton_Click(object sender, EventArgs e) {
            // only start up the gamepad if it's not already running.
            if (ds4 == null) {              // if gamepad is null,
                ds4 = new DualShock4(this); // make a new one, passing a reference to this form.
                Task t = Task.Run(() => {   // run in separate thread to not lock up the ui.
                    ds4.gamepad();          // locking function. If we come out of here, 
                    ds4 = null;             // destroy our gamepad because we're done with it, 
                                            // so maybe a new one can be made later.
                });
            }
            else { // gamepad already running, do nothing.
                log("Error: Gamepad already running!");
            }
        }

        public MainWindow() {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            ipCombobox.Items.Add(new IPItem("ares-wifi", "192.168.1.3"));
            ipCombobox.Items.Add(new IPItem("ares-ethernet", "192.168.1.4"));
            ipCombobox.Items.Add(new IPItem("(TEST) pmc43.ddns.net", "pmc43.ddns.net"));
            ipCombobox.Items.Add(new IPItem("(TEST) localhost", "127.0.0.1"));
            ipCombobox.DisplayMember = "Name";
            ipCombobox.ValueMember = "Ip";
            ipCombobox.SelectedIndex = 0;
            console.Text = GetTimestamp(DateTime.Now) + " initialized.";
            
        }

        #region Exit App
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { // exit app
            Application.Exit();
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) { // exit app
            Application.Exit();
        }
        #endregion
        private void buttonConnect_Click(object sender, EventArgs e) {
            doDisconnect = false;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            log("Connecting to " + ipCombobox.SelectedItem.ToString() + "..");
            try {
                socket.Connect(ipCombobox.SelectedItem.ToString(), 25555);
                log("connected!");
                ipCombobox.Enabled = false;
                ipCombobox.BackColor = System.Drawing.Color.Green;
                buttonConnect.Enabled = false;
                disconnectButton.Enabled = true;
                disconnectButton.BackColor = System.Drawing.Color.Transparent;
                enableCommands();
                recv = Task.Run(() => {
                    while (true) {
                        if (doDisconnect) break;
                        if (!isConnected(socket)) {
                            disconnectButton_Click(null, null);
                            doDisconnect = true;
                            break;
                        }
                        socket.Receive(incomingBuf);
                        log("Robot: " + System.Text.Encoding.UTF8.GetString(incomingBuf));
                        var str = System.Text.Encoding.Default.GetString(incomingBuf);
                        incomingBuf = new Byte[256];
                        if (str.Substring(0, 4).Equals("BATT")) {
                            str = str.Substring(5);
                            str = Regex.Replace(str, @"\t|\n|\r", "");
                            str = Regex.Replace(str, @"\s+", "");
                            float batt = float.Parse(str);
                            int percent = (int) (((batt-12.0) * 100.0)/(13.6-12.0));
                            labelBatteryVolts.Text = batt.ToString() + "v   -   " + percent + "%";
                            /* range = max - min
                            correctedStartValue = input - min
                            percentage = (correctedStartValue * 100) / range */
                        }
                        else if(str.Substring(0, 3).Equals("SIG")) {
                            // receive the signal strength
                        }
                    }
                });
                
                // Create a timer
                System.Timers.Timer myTimer = new System.Timers.Timer();
                // Tell the timer what to do when it elapses
                myTimer.Elapsed += new ElapsedEventHandler(requestBatt);
                // Set it to go off every <milliseconds>
                myTimer.Interval = 20000;
                // And start it        
                myTimer.Enabled = true;
            }
            catch (Exception ex) {
                log("Problem connecting: " + ex.Message);
                return;
            }
        }
        #region About / Save Logs functionality
        private void saveConsoleLogsToolStripMenuItem_Click(object sender, EventArgs e) // show save dialog
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
        #endregion
        private void disconnectButton_Click(object sender, EventArgs e) {
            try {
                doDisconnect = true;
                socket.Close();
                log("Successfully disconnected.");
                ds4 = null;
                log("Gamepad wiped");
                recv.Dispose();

                ipCombobox.Enabled = true;
                ipCombobox.BackColor = System.Drawing.Color.White;
                buttonConnect.Enabled = true;
                disconnectButton.Enabled = false;
                disconnectButton.BackColor = System.Drawing.Color.Silver;
            }
            catch (Exception ex) {
                log("Error in disconnection function: " + ex.Message);
                return;
            }
        }

        /// <summary>
        /// takes the text value of the custom command box and
        /// sends it to the robot.
        /// </summary>
        private void sendCustomCommand(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return) {
                send(txtCustomCommand.Text);
                txtCustomCommand.Text = "";
            }
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
            log("GUI: " + s);
            try {
                socket.Send(System.Text.Encoding.UTF8.GetBytes(s + ";"));
            } catch(Exception ex) {
                log("Socket error, disconnecting: " + ex.Message);
                log("Disconnecting");
                disconnectButton_Click(null, null);
            }
        }
        private void btn_MouseDown(object sender, MouseEventArgs e) {
            var btn = (FontAwesomeIcons.IconButton)sender;
            btn.BackColor = System.Drawing.Color.Gold;
            bool dualMode = dualModeCheckBox.Checked;
            switch (btn.Name) {
                case "goForward":  send("^"); break; // GO FWD
                case "goBackward": send("v"); break; // GO BACKWARD
                case "turnCW":     send(">"); break; // TURN RIGHT
                case "turnCCW":    send("<"); break; // TURN LEFT
                case "raiseBot": send("u"); break; // RETRACT ACTUATORS
                case "lowerBot": send("t"); break; // EXTEND ACTUATORS
                case "raise_f":  send("z"); break; // RAISE FRONT DRUM
                case "lower_f":  send("x"); break; // LOWER FRONT DRUM
                case "mine_f":   send("p"); break; // MINE FRONT DRUM
                case "dump_f":   send("l"); break; // DUMP FRONT DRUM
                case "raise_r":  send("c"); break; // RAISE REAR DRUM
                case "lower_r":  send("f"); break; // LOWER REAR DRUM
                case "mine_r":   send("o"); break; // MINE REAR DRUM
                case "dump_r":   send("k"); break; // DUMP REAR DRUM
                case "disconnectButton": break;
                default:
                    log("Unrecognized button.");
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
            else if (btn.Name.Equals("raiseBot") || btn.Name.Equals("lowerBot")) {
                send("y");
            }
            else send("*");
        }

        public void btnFakePress(object button) {
            var btn = (FontAwesomeIcons.IconButton)button;
            btn.BackColor = System.Drawing.Color.Gold;
        }
        public void btnFakeRelease(object button) {
            var btn = (FontAwesomeIcons.IconButton)button;
            btn.BackColor = System.Drawing.Color.Transparent;
        }

        private void enableCommands() {
            transportGroup.Enabled = true;
            miningGroup.Enabled = true;
        }
        private void disableCommands() {
            transportGroup.Enabled = false;
            miningGroup.Enabled = false;
        }

        /// <summary>
        /// check the connection to the robot
        /// </summary>
        /// <param name="socket">The socket to check if it's connected.</param>
        /// <returns>true if we're connected</returns>
        /// <returns>false if we're not connected</returns>
        public static bool isConnected(Socket socket) {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException) { return false; }
        }

        /// <summary>
        /// sends a letter 'b' to the robot to receive battery voltage
        /// </summary>
        private void requestBatt(object source, ElapsedEventArgs e) {
            send("b");
        }

        /// <summary>
        /// shows the button mapping window
        /// </summary>
        private void buttonMapToolStripMenuItem_Click(object sender, EventArgs e) {
            ButtonMap buttonMap = new ButtonMap();
            buttonMap.Show();
        }
    }
}
