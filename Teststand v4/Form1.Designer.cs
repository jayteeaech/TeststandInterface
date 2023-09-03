namespace Teststand_v4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CommandHistoryBox = new System.Windows.Forms.TextBox();
            this.b_manualCommandSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ManualCommandBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.diagnostic = new System.Windows.Forms.TabPage();
            this.b_currentPos = new System.Windows.Forms.Button();
            this.b_loopStatus = new System.Windows.Forms.Button();
            this.SequenceTab = new System.Windows.Forms.TabPage();
            this.seqProgressBar = new System.Windows.Forms.ProgressBar();
            this.mechdelaybox = new System.Windows.Forms.NumericUpDown();
            this.trgDelay = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nTrg = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.b_SendTrgToggle = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.seqResTextY = new System.Windows.Forms.TextBox();
            this.seqResTextX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.seqResY = new System.Windows.Forms.NumericUpDown();
            this.seqSizeY = new System.Windows.Forms.NumericUpDown();
            this.seqCenterY = new System.Windows.Forms.NumericUpDown();
            this.seqResX = new System.Windows.Forms.NumericUpDown();
            this.seqSizeX = new System.Windows.Forms.NumericUpDown();
            this.seqCenterX = new System.Windows.Forms.NumericUpDown();
            this.setSeqCenter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_AbortMotion = new System.Windows.Forms.Button();
            this.b_savesequence = new System.Windows.Forms.Button();
            this.b_SequenceExecute = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Communication = new System.Windows.Forms.TabPage();
            this.b_homeAxes = new System.Windows.Forms.Button();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.cb_comPortList = new System.Windows.Forms.ComboBox();
            this.comDisconnect = new System.Windows.Forms.Button();
            this.comConnect = new System.Windows.Forms.Button();
            this.comListRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.d_comTest = new System.Windows.Forms.Button();
            this.init = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.absPosY = new System.Windows.Forms.NumericUpDown();
            this.b_absPosGo = new System.Windows.Forms.Button();
            this.absPosX = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButtonsubmm = new System.Windows.Forms.RadioButton();
            this.radiobutton1mm = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton100mm = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton10mm = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.trgDelay2 = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.b_stopContinuousTrg = new System.Windows.Forms.Button();
            this.b_startContinuousTrg = new System.Windows.Forms.Button();
            this.d_trigTest = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.b_HLFBx = new System.Windows.Forms.Button();
            this.b_HLFBy = new System.Windows.Forms.Button();
            this.b_homeOverride = new System.Windows.Forms.Button();
            this.b_verboseEnable = new System.Windows.Forms.Button();
            this.b_verboseDisable = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.t1Box = new System.Windows.Forms.NumericUpDown();
            this.d_t1Set = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.diagnostic.SuspendLayout();
            this.SequenceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechdelaybox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trgDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqResY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqCenterY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqResX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqCenterX)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Communication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.init.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absPosX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trgDelay2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandHistoryBox
            // 
            this.CommandHistoryBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandHistoryBox.Location = new System.Drawing.Point(371, 93);
            this.CommandHistoryBox.Multiline = true;
            this.CommandHistoryBox.Name = "CommandHistoryBox";
            this.CommandHistoryBox.ReadOnly = true;
            this.CommandHistoryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommandHistoryBox.Size = new System.Drawing.Size(277, 250);
            this.CommandHistoryBox.TabIndex = 13;
            // 
            // b_manualCommandSend
            // 
            this.b_manualCommandSend.Enabled = false;
            this.b_manualCommandSend.Location = new System.Drawing.Point(573, 359);
            this.b_manualCommandSend.Name = "b_manualCommandSend";
            this.b_manualCommandSend.Size = new System.Drawing.Size(75, 23);
            this.b_manualCommandSend.TabIndex = 23;
            this.b_manualCommandSend.Text = "Send";
            this.b_manualCommandSend.UseVisualStyleBackColor = true;
            this.b_manualCommandSend.Click += new System.EventHandler(this.b_manualCommandSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manual Command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Command History:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ManualCommandBox
            // 
            this.ManualCommandBox.Enabled = false;
            this.ManualCommandBox.Location = new System.Drawing.Point(371, 362);
            this.ManualCommandBox.Name = "ManualCommandBox";
            this.ManualCommandBox.Size = new System.Drawing.Size(195, 20);
            this.ManualCommandBox.TabIndex = 21;
            this.ManualCommandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManualCommandBox_KeyDown);
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Help;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 37);
            this.label15.TabIndex = 27;
            this.label15.Text = "Big Boi";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.DoubleClick += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(13, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 18);
            this.label16.TabIndex = 26;
            this.label16.Text = "Stage Control Interface";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diagnostic
            // 
            this.diagnostic.Controls.Add(this.label17);
            this.diagnostic.Controls.Add(this.t1Box);
            this.diagnostic.Controls.Add(this.d_t1Set);
            this.diagnostic.Controls.Add(this.b_verboseDisable);
            this.diagnostic.Controls.Add(this.b_verboseEnable);
            this.diagnostic.Controls.Add(this.b_homeOverride);
            this.diagnostic.Controls.Add(this.b_HLFBy);
            this.diagnostic.Controls.Add(this.b_HLFBx);
            this.diagnostic.Controls.Add(this.b_currentPos);
            this.diagnostic.Controls.Add(this.b_loopStatus);
            this.diagnostic.Location = new System.Drawing.Point(4, 22);
            this.diagnostic.Name = "diagnostic";
            this.diagnostic.Padding = new System.Windows.Forms.Padding(3);
            this.diagnostic.Size = new System.Drawing.Size(346, 282);
            this.diagnostic.TabIndex = 1;
            this.diagnostic.Text = "Diagnostic";
            this.diagnostic.UseVisualStyleBackColor = true;
            // 
            // b_currentPos
            // 
            this.b_currentPos.Location = new System.Drawing.Point(58, 58);
            this.b_currentPos.Name = "b_currentPos";
            this.b_currentPos.Size = new System.Drawing.Size(214, 23);
            this.b_currentPos.TabIndex = 2;
            this.b_currentPos.Text = "Get Current Position";
            this.b_currentPos.UseVisualStyleBackColor = true;
            this.b_currentPos.Click += new System.EventHandler(this.b_currentPos_Click);
            // 
            // b_loopStatus
            // 
            this.b_loopStatus.Location = new System.Drawing.Point(58, 30);
            this.b_loopStatus.Name = "b_loopStatus";
            this.b_loopStatus.Size = new System.Drawing.Size(214, 23);
            this.b_loopStatus.TabIndex = 1;
            this.b_loopStatus.Text = "Get Loop Status";
            this.b_loopStatus.UseVisualStyleBackColor = true;
            this.b_loopStatus.Click += new System.EventHandler(this.b_loopStatus_Click);
            // 
            // SequenceTab
            // 
            this.SequenceTab.Controls.Add(this.seqProgressBar);
            this.SequenceTab.Controls.Add(this.mechdelaybox);
            this.SequenceTab.Controls.Add(this.trgDelay);
            this.SequenceTab.Controls.Add(this.label14);
            this.SequenceTab.Controls.Add(this.nTrg);
            this.SequenceTab.Controls.Add(this.label27);
            this.SequenceTab.Controls.Add(this.b_SendTrgToggle);
            this.SequenceTab.Controls.Add(this.label26);
            this.SequenceTab.Controls.Add(this.seqResTextY);
            this.SequenceTab.Controls.Add(this.seqResTextX);
            this.SequenceTab.Controls.Add(this.label13);
            this.SequenceTab.Controls.Add(this.label10);
            this.SequenceTab.Controls.Add(this.label6);
            this.SequenceTab.Controls.Add(this.label12);
            this.SequenceTab.Controls.Add(this.label9);
            this.SequenceTab.Controls.Add(this.label7);
            this.SequenceTab.Controls.Add(this.seqResY);
            this.SequenceTab.Controls.Add(this.seqSizeY);
            this.SequenceTab.Controls.Add(this.seqCenterY);
            this.SequenceTab.Controls.Add(this.seqResX);
            this.SequenceTab.Controls.Add(this.seqSizeX);
            this.SequenceTab.Controls.Add(this.seqCenterX);
            this.SequenceTab.Controls.Add(this.setSeqCenter);
            this.SequenceTab.Controls.Add(this.button1);
            this.SequenceTab.Controls.Add(this.label11);
            this.SequenceTab.Controls.Add(this.label8);
            this.SequenceTab.Controls.Add(this.label5);
            this.SequenceTab.Controls.Add(this.b_AbortMotion);
            this.SequenceTab.Controls.Add(this.b_savesequence);
            this.SequenceTab.Controls.Add(this.b_SequenceExecute);
            this.SequenceTab.Location = new System.Drawing.Point(4, 22);
            this.SequenceTab.Name = "SequenceTab";
            this.SequenceTab.Padding = new System.Windows.Forms.Padding(3);
            this.SequenceTab.Size = new System.Drawing.Size(346, 282);
            this.SequenceTab.TabIndex = 0;
            this.SequenceTab.Text = "(3) Sequence";
            this.SequenceTab.UseVisualStyleBackColor = true;
            // 
            // seqProgressBar
            // 
            this.seqProgressBar.Location = new System.Drawing.Point(5, 261);
            this.seqProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.seqProgressBar.Name = "seqProgressBar";
            this.seqProgressBar.Size = new System.Drawing.Size(339, 15);
            this.seqProgressBar.TabIndex = 20;
            // 
            // mechdelaybox
            // 
            this.mechdelaybox.Location = new System.Drawing.Point(10, 209);
            this.mechdelaybox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mechdelaybox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mechdelaybox.Name = "mechdelaybox";
            this.mechdelaybox.Size = new System.Drawing.Size(51, 20);
            this.mechdelaybox.TabIndex = 18;
            this.mechdelaybox.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // trgDelay
            // 
            this.trgDelay.Location = new System.Drawing.Point(9, 235);
            this.trgDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.trgDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trgDelay.Name = "trgDelay";
            this.trgDelay.Size = new System.Drawing.Size(51, 20);
            this.trgDelay.TabIndex = 18;
            this.trgDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "ms between move end and trigger";
            // 
            // nTrg
            // 
            this.nTrg.Location = new System.Drawing.Point(10, 183);
            this.nTrg.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nTrg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTrg.Name = "nTrg";
            this.nTrg.Size = new System.Drawing.Size(51, 20);
            this.nTrg.TabIndex = 19;
            this.nTrg.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(66, 237);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(165, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "ms between \"Ready\" and Trigger";
            // 
            // b_SendTrgToggle
            // 
            this.b_SendTrgToggle.AutoSize = true;
            this.b_SendTrgToggle.Location = new System.Drawing.Point(9, 160);
            this.b_SendTrgToggle.Name = "b_SendTrgToggle";
            this.b_SendTrgToggle.Size = new System.Drawing.Size(146, 17);
            this.b_SendTrgToggle.TabIndex = 17;
            this.b_SendTrgToggle.Text = "Send Trigger after Motion";
            this.b_SendTrgToggle.UseVisualStyleBackColor = true;
            this.b_SendTrgToggle.CheckedChanged += new System.EventHandler(this.b_SendTrgToggle_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(67, 185);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "# of Triggers";
            // 
            // seqResTextY
            // 
            this.seqResTextY.Enabled = false;
            this.seqResTextY.Location = new System.Drawing.Point(112, 133);
            this.seqResTextY.Name = "seqResTextY";
            this.seqResTextY.Size = new System.Drawing.Size(53, 20);
            this.seqResTextY.TabIndex = 14;
            // 
            // seqResTextX
            // 
            this.seqResTextX.Enabled = false;
            this.seqResTextX.Location = new System.Drawing.Point(33, 134);
            this.seqResTextX.Name = "seqResTextX";
            this.seqResTextX.Size = new System.Drawing.Size(53, 20);
            this.seqResTextX.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // seqResY
            // 
            this.seqResY.Location = new System.Drawing.Point(112, 107);
            this.seqResY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seqResY.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.seqResY.Name = "seqResY";
            this.seqResY.Size = new System.Drawing.Size(53, 20);
            this.seqResY.TabIndex = 6;
            this.seqResY.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.seqResY.ValueChanged += new System.EventHandler(this.refreshSequenceDisplays);
            // 
            // seqSizeY
            // 
            this.seqSizeY.Location = new System.Drawing.Point(112, 66);
            this.seqSizeY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seqSizeY.Name = "seqSizeY";
            this.seqSizeY.Size = new System.Drawing.Size(53, 20);
            this.seqSizeY.TabIndex = 4;
            this.seqSizeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seqSizeY.ValueChanged += new System.EventHandler(this.refreshSequenceDisplays);
            // 
            // seqCenterY
            // 
            this.seqCenterY.Location = new System.Drawing.Point(112, 25);
            this.seqCenterY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seqCenterY.Name = "seqCenterY";
            this.seqCenterY.Size = new System.Drawing.Size(53, 20);
            this.seqCenterY.TabIndex = 2;
            // 
            // seqResX
            // 
            this.seqResX.Location = new System.Drawing.Point(33, 107);
            this.seqResX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seqResX.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.seqResX.Name = "seqResX";
            this.seqResX.Size = new System.Drawing.Size(53, 20);
            this.seqResX.TabIndex = 5;
            this.seqResX.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.seqResX.ValueChanged += new System.EventHandler(this.refreshSequenceDisplays);
            // 
            // seqSizeX
            // 
            this.seqSizeX.Location = new System.Drawing.Point(33, 66);
            this.seqSizeX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seqSizeX.Name = "seqSizeX";
            this.seqSizeX.Size = new System.Drawing.Size(53, 20);
            this.seqSizeX.TabIndex = 3;
            this.seqSizeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seqSizeX.ValueChanged += new System.EventHandler(this.refreshSequenceDisplays);
            // 
            // seqCenterX
            // 
            this.seqCenterX.Location = new System.Drawing.Point(33, 25);
            this.seqCenterX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seqCenterX.Name = "seqCenterX";
            this.seqCenterX.Size = new System.Drawing.Size(53, 20);
            this.seqCenterX.TabIndex = 1;
            // 
            // setSeqCenter
            // 
            this.setSeqCenter.Location = new System.Drawing.Point(225, 21);
            this.setSeqCenter.Name = "setSeqCenter";
            this.setSeqCenter.Size = new System.Drawing.Size(50, 23);
            this.setSeqCenter.TabIndex = 8;
            this.setSeqCenter.Text = "GET";
            this.setSeqCenter.UseVisualStyleBackColor = true;
            this.setSeqCenter.Click += new System.EventHandler(this.setSeqCenter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Resolution [# Locations]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sample Area Size [mm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sequence Center [mm]";
            // 
            // b_AbortMotion
            // 
            this.b_AbortMotion.BackColor = System.Drawing.Color.Salmon;
            this.b_AbortMotion.Enabled = false;
            this.b_AbortMotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_AbortMotion.Location = new System.Drawing.Point(275, 212);
            this.b_AbortMotion.Name = "b_AbortMotion";
            this.b_AbortMotion.Size = new System.Drawing.Size(65, 42);
            this.b_AbortMotion.TabIndex = 10;
            this.b_AbortMotion.Text = "E-STOP";
            this.b_AbortMotion.UseVisualStyleBackColor = false;
            this.b_AbortMotion.Click += new System.EventHandler(this.b_AbortMotion_Click);
            // 
            // b_savesequence
            // 
            this.b_savesequence.Location = new System.Drawing.Point(275, 116);
            this.b_savesequence.Name = "b_savesequence";
            this.b_savesequence.Size = new System.Drawing.Size(65, 42);
            this.b_savesequence.TabIndex = 9;
            this.b_savesequence.Text = "Save Sequence";
            this.b_savesequence.UseVisualStyleBackColor = true;
            this.b_savesequence.Click += new System.EventHandler(this.b_savesequence_Click);
            // 
            // b_SequenceExecute
            // 
            this.b_SequenceExecute.Enabled = false;
            this.b_SequenceExecute.Location = new System.Drawing.Point(275, 164);
            this.b_SequenceExecute.Name = "b_SequenceExecute";
            this.b_SequenceExecute.Size = new System.Drawing.Size(65, 42);
            this.b_SequenceExecute.TabIndex = 9;
            this.b_SequenceExecute.Text = "Execute Sequence";
            this.b_SequenceExecute.UseVisualStyleBackColor = true;
            this.b_SequenceExecute.Click += new System.EventHandler(this.b_MotionExecute_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Communication);
            this.tabControl1.Controls.Add(this.init);
            this.tabControl1.Controls.Add(this.SequenceTab);
            this.tabControl1.Controls.Add(this.diagnostic);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // Communication
            // 
            this.Communication.Controls.Add(this.pictureBox1);
            this.Communication.Controls.Add(this.groupBox4);
            this.Communication.Controls.Add(this.b_homeAxes);
            this.Communication.Controls.Add(this.d_comTest);
            this.Communication.Location = new System.Drawing.Point(4, 22);
            this.Communication.Margin = new System.Windows.Forms.Padding(2);
            this.Communication.Name = "Communication";
            this.Communication.Size = new System.Drawing.Size(346, 282);
            this.Communication.TabIndex = 3;
            this.Communication.Text = "(1) Communication";
            this.Communication.UseVisualStyleBackColor = true;
            // 
            // b_homeAxes
            // 
            this.b_homeAxes.Location = new System.Drawing.Point(275, 167);
            this.b_homeAxes.Name = "b_homeAxes";
            this.b_homeAxes.Size = new System.Drawing.Size(65, 42);
            this.b_homeAxes.TabIndex = 33;
            this.b_homeAxes.Text = "Home Axes";
            this.b_homeAxes.UseVisualStyleBackColor = true;
            this.b_homeAxes.Click += new System.EventHandler(this.b_homeAxes_Click);
            // 
            // baudBox
            // 
            this.baudBox.Location = new System.Drawing.Point(62, 46);
            this.baudBox.Maximum = new decimal(new int[] {
            256000,
            0,
            0,
            0});
            this.baudBox.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(120, 20);
            this.baudBox.TabIndex = 32;
            this.baudBox.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // cb_comPortList
            // 
            this.cb_comPortList.FormattingEnabled = true;
            this.cb_comPortList.Location = new System.Drawing.Point(62, 18);
            this.cb_comPortList.Name = "cb_comPortList";
            this.cb_comPortList.Size = new System.Drawing.Size(121, 21);
            this.cb_comPortList.TabIndex = 31;
            // 
            // comDisconnect
            // 
            this.comDisconnect.Location = new System.Drawing.Point(143, 72);
            this.comDisconnect.Name = "comDisconnect";
            this.comDisconnect.Size = new System.Drawing.Size(75, 23);
            this.comDisconnect.TabIndex = 29;
            this.comDisconnect.Text = "Disconnect";
            this.comDisconnect.UseVisualStyleBackColor = true;
            this.comDisconnect.Click += new System.EventHandler(this.comDisconnect_Click);
            // 
            // comConnect
            // 
            this.comConnect.Location = new System.Drawing.Point(62, 72);
            this.comConnect.Name = "comConnect";
            this.comConnect.Size = new System.Drawing.Size(75, 23);
            this.comConnect.TabIndex = 30;
            this.comConnect.Text = "Connect";
            this.comConnect.UseVisualStyleBackColor = true;
            this.comConnect.Click += new System.EventHandler(this.comConnect_Click);
            // 
            // comListRefresh
            // 
            this.comListRefresh.Location = new System.Drawing.Point(189, 16);
            this.comListRefresh.Name = "comListRefresh";
            this.comListRefresh.Size = new System.Drawing.Size(53, 23);
            this.comListRefresh.TabIndex = 28;
            this.comListRefresh.Text = "Refresh";
            this.comListRefresh.UseVisualStyleBackColor = true;
            this.comListRefresh.Click += new System.EventHandler(this.comListRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "COM Baud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "COM Port:";
            // 
            // d_comTest
            // 
            this.d_comTest.Enabled = false;
            this.d_comTest.Location = new System.Drawing.Point(275, 212);
            this.d_comTest.Name = "d_comTest";
            this.d_comTest.Size = new System.Drawing.Size(65, 42);
            this.d_comTest.TabIndex = 1;
            this.d_comTest.Text = "COM Test";
            this.d_comTest.UseVisualStyleBackColor = true;
            this.d_comTest.Click += new System.EventHandler(this.d_comTest_Click);
            // 
            // init
            // 
            this.init.Controls.Add(this.button3);
            this.init.Controls.Add(this.groupBox3);
            this.init.Controls.Add(this.groupBox2);
            this.init.Controls.Add(this.groupBox1);
            this.init.Location = new System.Drawing.Point(4, 22);
            this.init.Margin = new System.Windows.Forms.Padding(2);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(346, 282);
            this.init.TabIndex = 4;
            this.init.Text = "(2) Initialization";
            this.init.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.absPosY);
            this.groupBox3.Controls.Add(this.b_absPosGo);
            this.groupBox3.Controls.Add(this.absPosX);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(266, 47);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Absolute Position [mm]";
            // 
            // absPosY
            // 
            this.absPosY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.absPosY.Location = new System.Drawing.Point(119, 21);
            this.absPosY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.absPosY.Name = "absPosY";
            this.absPosY.Size = new System.Drawing.Size(53, 20);
            this.absPosY.TabIndex = 2;
            // 
            // b_absPosGo
            // 
            this.b_absPosGo.Location = new System.Drawing.Point(177, 18);
            this.b_absPosGo.Name = "b_absPosGo";
            this.b_absPosGo.Size = new System.Drawing.Size(50, 23);
            this.b_absPosGo.TabIndex = 0;
            this.b_absPosGo.Text = "GO";
            this.b_absPosGo.UseVisualStyleBackColor = true;
            this.b_absPosGo.Click += new System.EventHandler(this.b_absPosGo_Click);
            // 
            // absPosX
            // 
            this.absPosX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.absPosX.Location = new System.Drawing.Point(40, 21);
            this.absPosX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.absPosX.Name = "absPosX";
            this.absPosX.Size = new System.Drawing.Size(53, 20);
            this.absPosX.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(99, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Y";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.radioButtonsubmm);
            this.groupBox2.Controls.Add(this.radiobutton1mm);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.radioButton100mm);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.radioButton10mm);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(4, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 107);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Jog";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button6.Location = new System.Drawing.Point(109, 37);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 36);
            this.button6.TabIndex = 23;
            this.button6.Text = "←";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.jogXneg);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // radioButtonsubmm
            // 
            this.radioButtonsubmm.AutoSize = true;
            this.radioButtonsubmm.Checked = true;
            this.radioButtonsubmm.Location = new System.Drawing.Point(11, 21);
            this.radioButtonsubmm.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonsubmm.Name = "radioButtonsubmm";
            this.radioButtonsubmm.Size = new System.Drawing.Size(59, 17);
            this.radioButtonsubmm.TabIndex = 20;
            this.radioButtonsubmm.TabStop = true;
            this.radioButtonsubmm.Text = "0.1 mm";
            this.radioButtonsubmm.UseVisualStyleBackColor = true;
            this.radioButtonsubmm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // radiobutton1mm
            // 
            this.radiobutton1mm.AutoSize = true;
            this.radiobutton1mm.Checked = true;
            this.radiobutton1mm.Location = new System.Drawing.Point(11, 40);
            this.radiobutton1mm.Margin = new System.Windows.Forms.Padding(2);
            this.radiobutton1mm.Name = "radiobutton1mm";
            this.radiobutton1mm.Size = new System.Drawing.Size(50, 17);
            this.radiobutton1mm.TabIndex = 20;
            this.radiobutton1mm.TabStop = true;
            this.radiobutton1mm.Text = "1 mm";
            this.radiobutton1mm.UseVisualStyleBackColor = true;
            this.radiobutton1mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button5.Location = new System.Drawing.Point(150, 57);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 36);
            this.button5.TabIndex = 23;
            this.button5.Text = "↓";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.jogYpos);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // radioButton100mm
            // 
            this.radioButton100mm.AutoSize = true;
            this.radioButton100mm.Location = new System.Drawing.Point(11, 77);
            this.radioButton100mm.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton100mm.Name = "radioButton100mm";
            this.radioButton100mm.Size = new System.Drawing.Size(62, 17);
            this.radioButton100mm.TabIndex = 21;
            this.radioButton100mm.Text = "100 mm";
            this.radioButton100mm.UseVisualStyleBackColor = true;
            this.radioButton100mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button4.Location = new System.Drawing.Point(190, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 36);
            this.button4.TabIndex = 23;
            this.button4.Text = "→";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.jogXpos);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // radioButton10mm
            // 
            this.radioButton10mm.AutoSize = true;
            this.radioButton10mm.Location = new System.Drawing.Point(11, 58);
            this.radioButton10mm.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton10mm.Name = "radioButton10mm";
            this.radioButton10mm.Size = new System.Drawing.Size(56, 17);
            this.radioButton10mm.TabIndex = 21;
            this.radioButton10mm.Text = "10 mm";
            this.radioButton10mm.UseVisualStyleBackColor = true;
            this.radioButton10mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(150, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.jogYneg);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyjog);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.trgDelay2);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.b_stopContinuousTrg);
            this.groupBox1.Controls.Add(this.b_startContinuousTrg);
            this.groupBox1.Controls.Add(this.d_trigTest);
            this.groupBox1.Location = new System.Drawing.Point(4, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 106);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trigger Setup";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(137, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "Delay [ms]:";
            // 
            // trgDelay2
            // 
            this.trgDelay2.Location = new System.Drawing.Point(140, 73);
            this.trgDelay2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.trgDelay2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trgDelay2.Name = "trgDelay2";
            this.trgDelay2.Size = new System.Drawing.Size(97, 20);
            this.trgDelay2.TabIndex = 26;
            this.trgDelay2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 13);
            this.label28.TabIndex = 25;
            this.label28.Text = "Continuous Trigger:";
            // 
            // b_stopContinuousTrg
            // 
            this.b_stopContinuousTrg.Location = new System.Drawing.Point(82, 69);
            this.b_stopContinuousTrg.Name = "b_stopContinuousTrg";
            this.b_stopContinuousTrg.Size = new System.Drawing.Size(51, 23);
            this.b_stopContinuousTrg.TabIndex = 23;
            this.b_stopContinuousTrg.Text = "Stop";
            this.b_stopContinuousTrg.UseVisualStyleBackColor = true;
            this.b_stopContinuousTrg.Click += new System.EventHandler(this.b_stopContinuousTrg_Click);
            // 
            // b_startContinuousTrg
            // 
            this.b_startContinuousTrg.Location = new System.Drawing.Point(26, 69);
            this.b_startContinuousTrg.Name = "b_startContinuousTrg";
            this.b_startContinuousTrg.Size = new System.Drawing.Size(51, 23);
            this.b_startContinuousTrg.TabIndex = 24;
            this.b_startContinuousTrg.Text = "Start";
            this.b_startContinuousTrg.UseVisualStyleBackColor = true;
            this.b_startContinuousTrg.Click += new System.EventHandler(this.b_startContinuousTrg_Click);
            // 
            // d_trigTest
            // 
            this.d_trigTest.Enabled = false;
            this.d_trigTest.Location = new System.Drawing.Point(26, 27);
            this.d_trigTest.Name = "d_trigTest";
            this.d_trigTest.Size = new System.Drawing.Size(214, 23);
            this.d_trigTest.TabIndex = 19;
            this.d_trigTest.Text = "Single Trigger";
            this.d_trigTest.UseVisualStyleBackColor = true;
            this.d_trigTest.Click += new System.EventHandler(this.d_trigTest_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(275, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "E-STOP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.b_AbortMotion_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comDisconnect);
            this.groupBox4.Controls.Add(this.baudBox);
            this.groupBox4.Controls.Add(this.comConnect);
            this.groupBox4.Controls.Add(this.comListRefresh);
            this.groupBox4.Controls.Add(this.cb_comPortList);
            this.groupBox4.Location = new System.Drawing.Point(6, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 107);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Communication Setup";
            // 
            // b_HLFBx
            // 
            this.b_HLFBx.Location = new System.Drawing.Point(58, 86);
            this.b_HLFBx.Name = "b_HLFBx";
            this.b_HLFBx.Size = new System.Drawing.Size(214, 23);
            this.b_HLFBx.TabIndex = 3;
            this.b_HLFBx.Text = "Get HLFBx status";
            this.b_HLFBx.UseVisualStyleBackColor = true;
            this.b_HLFBx.Click += new System.EventHandler(this.b_HLFBx_Click);
            // 
            // b_HLFBy
            // 
            this.b_HLFBy.Location = new System.Drawing.Point(58, 114);
            this.b_HLFBy.Name = "b_HLFBy";
            this.b_HLFBy.Size = new System.Drawing.Size(214, 23);
            this.b_HLFBy.TabIndex = 4;
            this.b_HLFBy.Text = "Get HLFBy status";
            this.b_HLFBy.UseVisualStyleBackColor = true;
            this.b_HLFBy.Click += new System.EventHandler(this.b_HLFBy_Click);
            // 
            // b_homeOverride
            // 
            this.b_homeOverride.Location = new System.Drawing.Point(58, 142);
            this.b_homeOverride.Name = "b_homeOverride";
            this.b_homeOverride.Size = new System.Drawing.Size(214, 23);
            this.b_homeOverride.TabIndex = 5;
            this.b_homeOverride.Text = "Set Current Location as Home";
            this.b_homeOverride.UseVisualStyleBackColor = true;
            this.b_homeOverride.Click += new System.EventHandler(this.b_homeOverride_Click);
            // 
            // b_verboseEnable
            // 
            this.b_verboseEnable.Location = new System.Drawing.Point(58, 171);
            this.b_verboseEnable.Name = "b_verboseEnable";
            this.b_verboseEnable.Size = new System.Drawing.Size(214, 23);
            this.b_verboseEnable.TabIndex = 5;
            this.b_verboseEnable.Text = "Enable Verbose Messages";
            this.b_verboseEnable.UseVisualStyleBackColor = true;
            this.b_verboseEnable.Click += new System.EventHandler(this.b_verboseEnable_Click);
            // 
            // b_verboseDisable
            // 
            this.b_verboseDisable.Location = new System.Drawing.Point(58, 200);
            this.b_verboseDisable.Name = "b_verboseDisable";
            this.b_verboseDisable.Size = new System.Drawing.Size(214, 23);
            this.b_verboseDisable.TabIndex = 5;
            this.b_verboseDisable.Text = "Disable Verbose Messages";
            this.b_verboseDisable.UseVisualStyleBackColor = true;
            this.b_verboseDisable.Click += new System.EventHandler(this.b_verboseDisable_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(388, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/jayteeaech/TeststandInterface";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(383, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(257, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Documentation and Source can be found on GitHub:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(60, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Trigger Length [μs]:";
            // 
            // t1Box
            // 
            this.t1Box.Location = new System.Drawing.Point(167, 229);
            this.t1Box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.t1Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.t1Box.Name = "t1Box";
            this.t1Box.Size = new System.Drawing.Size(62, 20);
            this.t1Box.TabIndex = 24;
            this.t1Box.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // d_t1Set
            // 
            this.d_t1Set.Enabled = false;
            this.d_t1Set.Location = new System.Drawing.Point(235, 227);
            this.d_t1Set.Name = "d_t1Set";
            this.d_t1Set.Size = new System.Drawing.Size(34, 23);
            this.d_t1Set.TabIndex = 23;
            this.d_t1Set.Text = "Set";
            this.d_t1Set.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 394);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ManualCommandBox);
            this.Controls.Add(this.CommandHistoryBox);
            this.Controls.Add(this.b_manualCommandSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(557, 389);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Stage Control Interface";
            this.diagnostic.ResumeLayout(false);
            this.diagnostic.PerformLayout();
            this.SequenceTab.ResumeLayout(false);
            this.SequenceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechdelaybox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trgDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqResY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqCenterY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqResX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seqCenterX)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Communication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            this.init.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absPosX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trgDelay2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CommandHistoryBox;
        private System.Windows.Forms.Button b_manualCommandSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ManualCommandBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage diagnostic;
        private System.Windows.Forms.TabPage SequenceTab;
        private System.Windows.Forms.TextBox seqResTextY;
        private System.Windows.Forms.TextBox seqResTextX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown seqResY;
        private System.Windows.Forms.NumericUpDown seqSizeY;
        private System.Windows.Forms.NumericUpDown seqCenterY;
        private System.Windows.Forms.NumericUpDown seqResX;
        private System.Windows.Forms.NumericUpDown seqSizeX;
        private System.Windows.Forms.NumericUpDown seqCenterX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_AbortMotion;
        private System.Windows.Forms.Button b_SequenceExecute;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button b_currentPos;
        private System.Windows.Forms.Button b_loopStatus;
        private System.Windows.Forms.Button b_savesequence;
        private System.Windows.Forms.TabPage Communication;
        private System.Windows.Forms.TabPage init;
        private System.Windows.Forms.NumericUpDown trgDelay;
        private System.Windows.Forms.NumericUpDown nTrg;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox b_SendTrgToggle;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button d_comTest;
        private System.Windows.Forms.NumericUpDown baudBox;
        private System.Windows.Forms.ComboBox cb_comPortList;
        private System.Windows.Forms.Button comDisconnect;
        private System.Windows.Forms.Button comConnect;
        private System.Windows.Forms.Button comListRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown trgDelay2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button b_stopContinuousTrg;
        private System.Windows.Forms.Button b_startContinuousTrg;
        private System.Windows.Forms.Button d_trigTest;
        private System.Windows.Forms.Button b_homeAxes;
        private System.Windows.Forms.RadioButton radiobutton1mm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton100mm;
        private System.Windows.Forms.RadioButton radioButton10mm;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown absPosY;
        private System.Windows.Forms.Button b_absPosGo;
        private System.Windows.Forms.NumericUpDown absPosX;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button setSeqCenter;
        private System.Windows.Forms.ProgressBar seqProgressBar;
        private System.Windows.Forms.RadioButton radioButtonsubmm;
        private System.Windows.Forms.NumericUpDown mechdelaybox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button b_HLFBy;
        private System.Windows.Forms.Button b_HLFBx;
        private System.Windows.Forms.Button b_homeOverride;
        private System.Windows.Forms.Button b_verboseDisable;
        private System.Windows.Forms.Button b_verboseEnable;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown t1Box;
        private System.Windows.Forms.Button d_t1Set;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

