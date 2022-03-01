using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Teststand_v4
{
    public partial class Form1 : Form
    {

        SerialPort sPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            GetAllPorts();
            refreshMotionDisplays();
        }
        public void GetAllPorts()
        {
            //List<String> allPorts = new List<String>();
            cb_comPortList.Items.Clear();
            foreach (String portName in SerialPort.GetPortNames())
            {
                cb_comPortList.Items.Add(portName);
            }
            cb_comPortList.SelectedIndex = 0;
        }

        private void comListRefresh_Click(object sender, EventArgs e)
        {
            GetAllPorts();
        }

        private void comConnect_Click(object sender, EventArgs e)
        {
            // Start background listener
            if (backgroundWorker1.IsBusy != true)
            {
                CommandHistoryBox.AppendText("[ UI ] > Connecting to [" + cb_comPortList.Text + "]...\r\n");

                // Setup Serial Port

                sPort.PortName = cb_comPortList.Text;
                sPort.BaudRate = Convert.ToInt32(baudBox.Value);
                sPort.ReadTimeout = 500;
                sPort.WriteTimeout = 500;
                sPort.Open();

                // Package serial port object for background worker
                var args = new WorkerArgs() { sPort = sPort };  // Old: { Port = cb_comPortList.Text, Baud = Convert.ToInt32(baudBox.Value) };

                backgroundWorker1.RunWorkerAsync(args);
                comConnect.Enabled = false;
                cb_comPortList.Enabled = false;
                baudBox.Enabled = false;
                ManualCommandBox.Enabled = true;
                b_manualCommandSend.Enabled = true;
                b_sendConf.Enabled = true;
                b_MotionExecute.Enabled = true;
                b_AbortMotion.Enabled = true;
                d_release.Enabled = true;
                d_t1Set.Enabled = true;
                d_t2Set.Enabled = true;
                d_pHoldSet.Enabled = true;
                d_comTest.Enabled = true;
                d_trigTest.Enabled = true;

                CommandHistoryBox.AppendText("[ UI ] > Connected.\r\n");

            }
            else
            {
                CommandHistoryBox.AppendText("[ UI ] > Worker already listening!\r\n");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkerArgs args = (WorkerArgs)e.Argument; // Extract arguments from Class container

            BackgroundWorker worker = sender as BackgroundWorker;


            // Start Worker Loop
            while (true)
            {
                if (worker.CancellationPending)  // Check to see if cancel button pressed
                {
                    e.Cancel = true;
                    // Inform client streaming has ended

                    // Close Port
                    args.sPort.Close();

                    // Stop the Loop
                    break;
                }
                else
                {
                    // Read the filestream to a string, report it to the main thread, and send its ASCII bytes to the network client
                    try
                    {
                        string line = args.sPort.ReadTo("\r");  // returned string does not include [value] and [value] is removed from buffer
                        worker.ReportProgress(0, line + "\r\n");
                    }
                    catch (TimeoutException) { }

                    //if (line != null)
                    //{
                    //    //line += Environment.NewLine;
                    //    worker.ReportProgress(0, line + "\r\n");

                    //    sPort.WriteLine(line);
                    //}
                    //else
                    //{
                    //    wh.WaitOne(1000); // wait for 1s or when file changes, whichever occurs first
                    //}
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CommandHistoryBox.AppendText("[ RX ] > " + (string)e.UserState); // Write the backgroundWorker's status to the status box
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string message = null;
            if (e.Cancelled == true)
            {
                message = "[ UI ] > Disconnected.";
            }
            else if (e.Error != null)
            {
                message = "[WRKR] > Error: " + e.Error.Message;
            }
            else
            {
                message = "[WRKR] > Reached End Condition\r\n[WORKER] Listening Stopped";
            }

            CommandHistoryBox.AppendText(message + Environment.NewLine);
            comConnect.Enabled = true;
            cb_comPortList.Enabled = true;
            baudBox.Enabled = true;
            ManualCommandBox.Enabled = false;
            b_manualCommandSend.Enabled = false;
            b_sendConf.Enabled = false;
            b_MotionExecute.Enabled = false;
            b_AbortMotion.Enabled = false;
            d_release.Enabled = false;
            d_t1Set.Enabled = false;
            d_t2Set.Enabled = false;
            d_pHoldSet.Enabled = false;
            d_comTest.Enabled = false;
            d_trigTest.Enabled = false;
        }

        internal class WorkerArgs
        {
            internal string Port { get; set; }
            internal int Baud { get; set; }
            internal SerialPort sPort { get; set; }
        }

        private void b_manualCommandSend_Click(object sender, EventArgs e)
        {
            msgSend(ManualCommandBox.Text + "\n");
            ManualCommandBox.Text = null;
        }

        private void msgSend(string msg)
        {
            CommandHistoryBox.AppendText("[ TX ] > " + msg + Environment.NewLine);
            sPort.Write(msg + "\n");
        }

        private void comDisconnect_Click(object sender, EventArgs e)
        {

            backgroundWorker1.CancelAsync();
        }

        private void ManualCommandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                msgSend(ManualCommandBox.Text);
                ManualCommandBox.Text = null;
            }
        }

        private void startpointBox_ValueChanged(object sender, EventArgs e)
        {
            refreshMotionDisplays();
        }

        private void refreshMotionDisplays()
        {
            float motion = (float)0.5 * ((float)nimagesBox.Value - 1) * (float)tdecBox.Value;
            float startpoint = (float)0.5 * (float)startpointBox.Value;
            float res = (float)0.5 * (float)tdecBox.Value;
            totalmotionBox.Text = startpoint.ToString() + " + " + motion.ToString();
            imageresolutionBox.Text = res.ToString();
        }

        private void b_sendConf_Click(object sender, EventArgs e)
        {
            // build commands for the microcontroller
           
            msgSend("M02:" + String.Format("{0:000}", startpointBox.Value) );  // Startpoint
            msgSend("M03:" + String.Format("{0:000}", nimagesBox.Value));      // # of Images
            msgSend("M04:" + String.Format("{0:000}", tdecBox.Value));         // Trigger Decimation

        }

        private void b_MotionExecute_Click(object sender, EventArgs e)
        {
            msgSend("M00"); // Execute Motion
        }

        private void b_AbortMotion_Click(object sender, EventArgs e)
        {
            msgSend("M01"); // Abort Motion
        }

        private void d_t1Set_Click(object sender, EventArgs e)
        {
            int PR1 = (int)(t1Box.Value * 500);
            msgSend("D01:" + String.Format("{0:000}", PR1));
        }

        private void d_t2Set_Click(object sender, EventArgs e)
        {
            int PR2 = (int)(t2Box.Value * 500);
            msgSend("D02:" + String.Format("{0:000}", PR2));
        }

        private void d_pHoldSet_Click(object sender, EventArgs e)
        {
            msgSend("D03:" + String.Format("{0:000}", pHoldBox.Value));
        }

        private void d_trigTest_Click(object sender, EventArgs e)
        {
            msgSend("D04");
        }

        private void d_comTest_Click(object sender, EventArgs e)
        {
            msgSend("D00");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Joe Howard, 2022\njoethoward@gmail.com");
        }
    }
}
    