using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.IO;
using System.Net.Sockets;

namespace ControlStation
{
    
    public partial class MainWindow : Form
    {
                
        RestClient client = new RestClient("https://api.particle.io");
        RestRequest request = new RestRequest("/v1/devices/250047001147343339383037/potvalue?access_token=55b63ee34abe2ef6078105497b30236d3f5b83e3");

        Socket socket;


        public MainWindow()
        {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            textboxIP.Text = "raspberrypi";
            console.Text = GetTimestamp(DateTime.Now) + " initialized.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var response = client.Execute<ParticleResponse>(request);
                label1.Text = "Requested value";
                System.Threading.Thread.Sleep(2000);
                if (response != null)
                {
                    ParticleResponse obj = response.Data;
                    label1.Text = obj.result;
                }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // exit app
        {
            Application.Exit();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) // exit app
        {
            Application.Exit();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            log("Connecting to " + textboxIP.Text + "..");
            batteryBar.PerformStep();
            try {
                socket.Connect(textboxIP.Text, 25555);
            } catch(Exception ex)
            {
                log("Problem connecting: " + ex.Message);
                return;
            }
            log("connected!");
            textboxIP.Enabled = false;
            textboxIP.BackColor = Color.Green;
            buttonConnect.Enabled = false;
            disconnectButton.Enabled = true;
            disconnectButton.BackColor = Color.Transparent;
        }

        private void saveConsoleLogsToolStripMenuItem_Click(object sender, EventArgs e) // save console contents to log file
        {
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

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Close();
            }
            catch (Exception ex)
            {
                log("Error disconnecting: " + ex.Message);
                return;
            }
            log("Successfully disconnected.");
            textboxIP.Enabled = true;
            textboxIP.BackColor = Color.White;
            buttonConnect.Enabled = true;
            disconnectButton.Enabled = false;
            disconnectButton.BackColor = Color.Silver;
        }

        //################      HELPER FUNCTIONS      ##################\\
        public void log(String s)
        {
            console.AppendText("\r\n" + GetTimestamp(DateTime.Now) + " " + s + "");
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }
        public static String GetFilePathTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMdd--HHmmss");
        }
        public void send(String s)
        {
            socket.Send(System.Text.Encoding.UTF8.GetBytes(s));
        }
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = (FontAwesomeIcons.IconButton)sender;
            btn.BackColor = Color.Gold;
            switch(btn.Name)
            {
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
                case "disconnectButton":
                    break;
                default:
                    break;
            }
        }
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            var btn = (FontAwesomeIcons.IconButton)sender;
            btn.BackColor = Color.Transparent;
            send("*");
            if (btn.Name == "disconnectButton") btn.BackColor = Color.Silver;
        }
    }
    public class ParticleResponse
    {
        public string name { get; set; }
        public string result { get; set; }
    }
}
