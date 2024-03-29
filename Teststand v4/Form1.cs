﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Teststand_v4
{
    public partial class Form1 : Form
    {

        SerialPort sPort = new SerialPort();
        public readonly double pulsPermm = 157.480; // # pulses per mm given motor 1000 pulse/rev and leadscrew pitch 3/8-16
        public bool sequenceActive = false;
       // public double jogmultiplier = 1;
        public bool listenForLocation = false;

        Sequence xseq = new Sequence();
        Sequence yseq = new Sequence();

        internal class Sequence
        {
            //internal bool Active;
            internal double min;
            internal double max;
            internal int n;
            internal double[] list;
            internal int idx;
            internal bool dir;
            internal bool end;

            internal void reset()
            {
                idx = 0;
                dir = true;
                end = false;
            }

            internal void SetSequence()
            {
                double diff = (max - min) / (n - 1);
                double[] build = new double[n];
                for (int i = 0; i < n; i++)
                {
                    build[i] = (min + i*diff);
                }
                list = build;
                idx = 0;
            }
            internal double GetNextPoint()
            {
                if (dir)
                {
                    idx++;
                    if (idx == n-1) { end = true; }
                }
                else
                {
                    idx--;
                    if (idx == 0) { end = true; }
                }
                return list[idx];
            }
            internal double GetCurrentPoint()
            {
                return list[idx];
            }
        }


        public Form1()
        {
            InitializeComponent();
            GetAllPorts();
            //refreshMotionDisplays();
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
                //b_exportSeq.Enabled = true;
                b_SequenceExecute.Enabled = true;
                b_AbortMotion.Enabled = true;
                //d_release.Enabled = true;
                d_t1Set.Enabled = true;
                //d_t2Set.Enabled = true;
                //d_pHoldSet.Enabled = true;
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
                    // Read the filestream to a string, and report it to the main thread
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
            string msg = (string)e.UserState;
            CommandHistoryBox.AppendText("[ RX ] > " + msg); // Write the backgroundWorker's status to the status box

            // send next point in sequence if receive "move done" (r1) response
            if(msg.EndsWith("r1\r\n") && sequenceActive)
            {
                int ProgressOverallCount;
                if (xseq.dir)
                {
                    ProgressOverallCount = (yseq.n * (yseq.idx - 1)) + xseq.idx;
                }
                else
                {
                    ProgressOverallCount = (yseq.n * (yseq.idx - 1)) + (xseq.n - xseq.idx);
                }
                seqProgressBar.Value = (int)( (float)ProgressOverallCount / (float)(yseq.n * xseq.n) );

                if (!xseq.end)
                {
                    msgSend("m03x" + (int)(xseq.GetNextPoint() * pulsPermm)); // set absolute position, send # of pulses
                    msgSend("m03y" + (int)(yseq.GetCurrentPoint() * pulsPermm));
                    msgSend("m02"); // execute move
                    if (xseq.end && yseq.end) { sequenceActive = false; MessageBox.Show("Sequence Complete!");  } // If both X and Y sequences are at their end, then whole array is finished
                }
                else
                {
                    msgSend("m03x" + (int)(xseq.GetCurrentPoint() * pulsPermm));
                    xseq.dir = !xseq.dir;
                    xseq.end = false;
                    msgSend("m03y" + (int)(yseq.GetNextPoint() * pulsPermm));
                    msgSend("m02"); // execute move
                }
            }
            if(msg.StartsWith("p") && listenForLocation)
            {
                listenForLocation = false;
                char[] delimiterchars = { ',', 'p' };
                string[] split = msg.Split(delimiterchars);
                try { seqCenterX.Value = Int32.Parse(split[1]); } catch { CommandHistoryBox.AppendText("[ UI ] > Unable to Parse " + split[1]); }
                try { seqCenterY.Value = Int32.Parse(split[2]); } catch { CommandHistoryBox.AppendText("[ UI ] > Unable to Parse " + split[2]); }
            }
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
                message = "[WRKR] > Reached End Condition\r\n[WRKR] > Listening Stopped.";
            }

            CommandHistoryBox.AppendText(message + Environment.NewLine);
            comConnect.Enabled = true;
            cb_comPortList.Enabled = true;
            baudBox.Enabled = true;
            ManualCommandBox.Enabled = false;
            b_manualCommandSend.Enabled = false;
            //b_exportSeq.Enabled = false;
            b_SequenceExecute.Enabled = false;
            b_AbortMotion.Enabled = false;
            //d_release.Enabled = false;
            d_t1Set.Enabled = false;
            //d_t2Set.Enabled = false;
            //d_pHoldSet.Enabled = false;
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
            msgSend(ManualCommandBox.Text);
            ManualCommandBox.Text = null;
        }

        private void msgSend(string msg)
        {
            //try
            //{
                sPort.Write(msg);
                CommandHistoryBox.AppendText("[ TX ] > " + msg + Environment.NewLine);
            //}
            //catch (Exception)
            //{
            //    CommandHistoryBox.AppendText("[ UI ] > Error: Serial Not Connected.");
            //    //throw;
            //}
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

        private void refreshSequenceDisplays(object sender, EventArgs e)
        {
            float deltax = (float)seqSizeX.Value / ((float)seqResX.Value - 1);
            float detlay = (float)seqSizeY.Value / ((float)seqResY.Value - 1);
            seqResTextX.Text = "Δ " + String.Format("{0:0.00}", deltax) + "mm";
            seqResTextY.Text = "Δ " + String.Format("{0:0.00}", detlay) + "mm";
        }

        private void initsequence()
        {
            // Update x sequence object with new values
            xseq.min = (double)seqCenterX.Value - (double)seqSizeX.Value / 2;
            xseq.max = (double)seqCenterX.Value + (double)seqSizeX.Value / 2;
            xseq.n = (int)seqResX.Value;
            xseq.reset();
            xseq.SetSequence();

            // Update y sequence object with new values
            yseq.min = (double)seqCenterY.Value - (double)seqSizeY.Value / 2;
            yseq.max = (double)seqCenterY.Value + (double)seqSizeY.Value / 2;
            yseq.n = (int)seqResY.Value;
            yseq.reset();
            yseq.SetSequence();

        }
        private void b_MotionExecute_Click(object sender, EventArgs e)
        {
            // Initialize Sequence for loop
            // next point sent when "move done" command received ( see backgroundworker1_progresschanged() )

            // Add error checking here.  Skipping for testing

            initsequence();

            // Set sequenceActive flag to true (will listen for "move done" response)
            sequenceActive = true;

            // Send first point
            msgSend("m03x" + (int)(xseq.GetCurrentPoint() * pulsPermm)); // set absolute position, send # of pulses
            msgSend("m03y" + (int)(yseq.GetCurrentPoint() * pulsPermm));
            msgSend("m02"); // execute move
        }

        private void b_AbortMotion_Click(object sender, EventArgs e)
        {
            sequenceActive = false;
            msgSend("d01"); // Abort Motion
        }

        private void d_t1Set_Click(object sender, EventArgs e)
        {
            int PR1 = (int)t1Box.Value;
            msgSend("d05:" + String.Format("{0:000}", PR1));
        }

        private void d_trigTest_Click(object sender, EventArgs e)
        {
            msgSend("d02");
        }

        private void d_comTest_Click(object sender, EventArgs e)
        {
            msgSend("d00");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Joe Howard, 2023\nhttps://github.com/jayteeaech/TeststandInterface\njoethoward@gmail.com");
        }

        private void b_SendTrgToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (b_SendTrgToggle.Checked)
            {
                msgSend("m10"); // enable trg out
                msgSend("m12:" + String.Format("{0:000}", (int)nTrg.Value));  // set # trg
                msgSend("m13:" + String.Format("{0:0000}", (int)trgDelay.Value)); // set #ms delay between trg
                msgSend("m14:" + String.Format("{0:0000}", (int)mechdelaybox.Value));
            }
            else
            {
                msgSend("m11"); // disable trg out
            }
        }

        private void b_absPosGo_Click(object sender, EventArgs e)
        {
            msgSend("m03x" + (long)((double)absPosX.Value * pulsPermm)); // set absolute position, send # of pulses
            msgSend("m03y" + (long)((double)absPosY.Value * pulsPermm));
            msgSend("m02"); // execute move
        }

        private void relPosGo(double relxmove, double relymove)
        {
            msgSend("m04x" + (int)((double)relxmove * pulsPermm)); // set relative position, send # of pulses
            msgSend("m04y" + (int)((double)relymove * pulsPermm));
            msgSend("m02"); // execute move
        }

        private void b_startContinuousTrg_Click(object sender, EventArgs e)
        {
            msgSend("m13:" + String.Format("{0:0000}", (int)trgDelay2.Value)); // set #ms delay between trg)
            msgSend("d03"); // start continuous trigger
        }

        private void b_stopContinuousTrg_Click(object sender, EventArgs e)
        {
            msgSend("d04"); // stop continuous trigger
        }

       
        private void b_homeAxes_Click(object sender, EventArgs e)
        {
            msgSend("m01"); // home axes
        }

        private void b_currentPos_Click(object sender, EventArgs e)
        {
            msgSend("d07");
        }

        private void b_loopStatus_Click(object sender, EventArgs e)
        {
            msgSend("d06");
        }

        private SaveFileDialog savefile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = @ "C:\";
            saveFileDialog1.Title = "Choose a File for Logging...";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            return saveFileDialog1;
        }

        private void b_savesequence_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            ////saveFileDialog1.InitialDirectory = @ "C:\";
            //saveFileDialog1.Title = "Choose a File for Logging...";
            //saveFileDialog1.CheckFileExists = false;
            //saveFileDialog1.CheckPathExists = false;
            //saveFileDialog1.DefaultExt = "txt";
            //saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;
            SaveFileDialog logfile = savefile();
            if (logfile.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = saveFileDialog1.FileName;

                CommandHistoryBox.AppendText("[ UI ] > Saving Sequence to: " + logfile.FileName + Environment.NewLine);
                using (StreamWriter sw = new StreamWriter(logfile.FileName))
                {
                    initsequence();

                    sw.WriteLine($"Sequence Saved: {DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
                    sw.WriteLine(xseq.GetCurrentPoint() + "," + yseq.GetCurrentPoint());
                    while (true)
                    {
                        if (!xseq.end)
                        {
                            sw.WriteLine(xseq.GetNextPoint() + "," + yseq.GetCurrentPoint());
                            if (xseq.end && yseq.end) { break; } // If both X and Y sequences are at their end, then whole array is finished
                        }
                        else
                        {
                            sw.WriteLine(xseq.GetCurrentPoint() + "," + yseq.GetNextPoint());
                            xseq.dir = !xseq.dir;
                            xseq.end = false;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msgSend("m03x" + (long)((double)seqCenterX.Value * pulsPermm)); // set absolute position, send # of pulses
            msgSend("m03y" + (long)((double)seqCenterY.Value * pulsPermm));
            msgSend("m02"); // execute move
        }

        private double jogmultiplier()
        {
            if (radiobutton1mm.Checked) { return 1.0; }
            if (radioButton10mm.Checked) { return 10.0; }
            if (radioButton100mm.Checked) { return 100.0; }
            if (radioButtonsubmm.Checked) { return 0.1; }
            return 0;
        }

        private void jogYpos(object sender, EventArgs e)
        {
            relPosGo(0, jogmultiplier());
        }
        private void jogYneg(object sender, EventArgs e)
        {
            relPosGo(0, -jogmultiplier());
        }
        private void jogXpos(object sender, EventArgs e)
        {
            relPosGo(jogmultiplier(),0);
        }
        private void jogXneg(object sender, EventArgs e)
        {
            relPosGo(-jogmultiplier(), 0);
        }

        private void keyjog(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)    {  jogYpos(sender, e);  }
            if (e.KeyCode == Keys.S)  {  jogYneg(sender, e);  }
            if (e.KeyCode == Keys.A)  {  jogXneg(sender, e);  }
            if (e.KeyCode == Keys.D) {  jogXpos(sender, e);  }
        }

        private void setSeqCenter_Click(object sender, EventArgs e)
        {
            msgSend("d07");
            listenForLocation = true; // Set flag for ProgressChanged to listen for 
        }

        private void b_HLFBx_Click(object sender, EventArgs e)
        {
            msgSend("d08");
        }

        private void b_HLFBy_Click(object sender, EventArgs e)
        {
            msgSend("d09");
        }

        private void b_homeOverride_Click(object sender, EventArgs e)
        {
            msgSend("d10");
        }

        private void b_verboseEnable_Click(object sender, EventArgs e)
        {
            msgSend("d11");
        }

        private void b_verboseDisable_Click(object sender, EventArgs e)
        {
            msgSend("d12");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jayteeaech/TeststandInterface");
        }
    }
}
    