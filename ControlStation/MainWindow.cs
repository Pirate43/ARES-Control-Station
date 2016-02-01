using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ControlStation {

    public partial class MainWindow : Form {
        
        Socket socket;
        DualShock4 ds4;
        Byte[] incomingBuf = new Byte[16];
        Task recv, battrecv;
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
            textboxIP.Text = "pmc43.ddns.net";
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
            log("Connecting to " + textboxIP.Text + "..");
            batteryBar.PerformStep(); // TODO relate to battery voltage
            try {
                socket.Connect(textboxIP.Text, 25555);
                log("connected!");
                textboxIP.Enabled = false;
                textboxIP.BackColor = System.Drawing.Color.Green;
                buttonConnect.Enabled = false;
                disconnectButton.Enabled = true;
                disconnectButton.BackColor = System.Drawing.Color.Transparent;
                enableCommands();
                recv = Task.Run(() => {
                    while (true) {
                        if (doDisconnect) break;
                        if (!isConnected(socket)) disconnectButton_Click(null, null); 
                        socket.Receive(incomingBuf);
                        log("Robot: " + System.Text.Encoding.UTF8.GetString(incomingBuf));
                        var str = System.Text.Encoding.Default.GetString(incomingBuf);
                        if (str.Substring(0, 4).Equals("BATT")) {
                            str = str.Substring(5);
                            int batt = int.Parse(str);
                            batteryBar.Value = batt;
                            battPercent.Text = batt + "%";
                        }
                        incomingBuf = new Byte[256];
                    }
                });
                battrecv = Task.Run(async () => { // receive battery on interval
                    while (true) {
                        if (doDisconnect) break;
                        send("b");
                        await Task.Delay(10000);
                    }
                });
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
                battrecv.Dispose();

                textboxIP.Enabled = true;
                textboxIP.BackColor = System.Drawing.Color.White;
                buttonConnect.Enabled = true;
                disconnectButton.Enabled = false;
                disconnectButton.BackColor = System.Drawing.Color.Silver;
            }
            catch (Exception ex) {
                log("Error in disconnection function: " + ex.Message);
                return;
            }
        }

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
            socket.Send(System.Text.Encoding.UTF8.GetBytes(s));
            log("GUI: " + s);
        }
        private void btn_MouseDown(object sender, MouseEventArgs e) {
            var btn = (FontAwesomeIcons.IconButton)sender;
            btn.BackColor = System.Drawing.Color.Gold;
            switch (btn.Name) {
                case "goForward":
                    send("^");
                    break;
                case "goBackward":
                    send("v");
                    break;
                case "turnCW":
                    send(">");
                    break;
                case "turnCCW":
                    send("<");
                    break;
                case "lowerMining":
                    send("L");
                    break;
                case "doMining":
                    send("M");
                    break;
                case "raiseMining":
                    send("R");
                    break;
                case "doDump":
                    send("D");
                    break;
                case "disconnectButton":
                    break;
                default:
                    MessageBox.Show("Unrecognized button");
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

        private void raiseBot_mouseDown(object sender, MouseEventArgs e) {
            send("u");
        }
        private void raiseBot_mouseUp(object sender, MouseEventArgs e) {
            send("y");
        }
        private void lowerBot_mouseDown(object sender, MouseEventArgs e) {
            send("t");
        }
        private void lowerBot_mouseUp(object sender, MouseEventArgs e) {
            raiseBot_mouseUp(sender, e);
        }

        public static bool isConnected(Socket socket) {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException) { return false; }
        }

    }
}
