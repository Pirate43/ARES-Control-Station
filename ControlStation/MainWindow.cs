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

namespace ControlStation
{
    
    public partial class MainWindow : Form
    {
        public void log(String s)
        {
            console.AppendText("\r\n" + GetTimestamp(DateTime.Now) + " " + s + "");
        }
        
        RestClient client = new RestClient("https://api.particle.io");
        RestRequest request = new RestRequest("/v1/devices/250047001147343339383037/potvalue?access_token=55b63ee34abe2ef6078105497b30236d3f5b83e3");

        public MainWindow()
        {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            textboxIP.Text = "192.168.1.150";
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
            log("Connecting to " + textboxIP.Text + "..");
            batteryBar.PerformStep();
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

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss");
        }
        public static String GetFilePathTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMdd--HHmmss");
        }
    }
    public class ParticleResponse
    {
        public string name { get; set; }
        public string result { get; set; }
    }
}
