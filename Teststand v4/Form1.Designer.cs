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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.ManualCommandBox = new System.Windows.Forms.TextBox();
            this.CommandHistoryBox = new System.Windows.Forms.TextBox();
            this.cb_comPortList = new System.Windows.Forms.ComboBox();
            this.b_manualCommandSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comDisconnect = new System.Windows.Forms.Button();
            this.comConnect = new System.Windows.Forms.Button();
            this.comListRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageresolutionBox = new System.Windows.Forms.TextBox();
            this.totalmotionBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tdecBox = new System.Windows.Forms.NumericUpDown();
            this.nimagesBox = new System.Windows.Forms.NumericUpDown();
            this.startpointBox = new System.Windows.Forms.NumericUpDown();
            this.b_AbortMotion = new System.Windows.Forms.Button();
            this.b_sendConf = new System.Windows.Forms.Button();
            this.b_MotionExecute = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.d_release = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pHoldBox = new System.Windows.Forms.NumericUpDown();
            this.t2Box = new System.Windows.Forms.NumericUpDown();
            this.t1Box = new System.Windows.Forms.NumericUpDown();
            this.d_pHoldSet = new System.Windows.Forms.Button();
            this.d_t2Set = new System.Windows.Forms.Button();
            this.d_t1Set = new System.Windows.Forms.Button();
            this.d_trigTest = new System.Windows.Forms.Button();
            this.d_comTest = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdecBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nimagesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startpointBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHoldBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1Box)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(13, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 18);
            this.label16.TabIndex = 26;
            this.label16.Text = "Teststand Interface";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Help;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 37);
            this.label15.TabIndex = 27;
            this.label15.Text = "Zero-Vis";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.DoubleClick += new System.EventHandler(this.label15_Click);
            // 
            // baudBox
            // 
            this.baudBox.Location = new System.Drawing.Point(248, 41);
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
            this.baudBox.TabIndex = 25;
            this.baudBox.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // ManualCommandBox
            // 
            this.ManualCommandBox.Enabled = false;
            this.ManualCommandBox.Location = new System.Drawing.Point(255, 324);
            this.ManualCommandBox.Name = "ManualCommandBox";
            this.ManualCommandBox.Size = new System.Drawing.Size(195, 20);
            this.ManualCommandBox.TabIndex = 21;
            this.ManualCommandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManualCommandBox_KeyDown);
            // 
            // CommandHistoryBox
            // 
            this.CommandHistoryBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandHistoryBox.Location = new System.Drawing.Point(254, 90);
            this.CommandHistoryBox.Multiline = true;
            this.CommandHistoryBox.Name = "CommandHistoryBox";
            this.CommandHistoryBox.ReadOnly = true;
            this.CommandHistoryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommandHistoryBox.Size = new System.Drawing.Size(277, 215);
            this.CommandHistoryBox.TabIndex = 13;
            // 
            // cb_comPortList
            // 
            this.cb_comPortList.FormattingEnabled = true;
            this.cb_comPortList.Location = new System.Drawing.Point(248, 13);
            this.cb_comPortList.Name = "cb_comPortList";
            this.cb_comPortList.Size = new System.Drawing.Size(121, 21);
            this.cb_comPortList.TabIndex = 24;
            // 
            // b_manualCommandSend
            // 
            this.b_manualCommandSend.Enabled = false;
            this.b_manualCommandSend.Location = new System.Drawing.Point(456, 321);
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
            this.label3.Location = new System.Drawing.Point(252, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manual Command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Command History:";
            // 
            // comDisconnect
            // 
            this.comDisconnect.Location = new System.Drawing.Point(456, 41);
            this.comDisconnect.Name = "comDisconnect";
            this.comDisconnect.Size = new System.Drawing.Size(75, 23);
            this.comDisconnect.TabIndex = 18;
            this.comDisconnect.Text = "Disconnect";
            this.comDisconnect.UseVisualStyleBackColor = true;
            this.comDisconnect.Click += new System.EventHandler(this.comDisconnect_Click);
            // 
            // comConnect
            // 
            this.comConnect.Location = new System.Drawing.Point(456, 12);
            this.comConnect.Name = "comConnect";
            this.comConnect.Size = new System.Drawing.Size(75, 23);
            this.comConnect.TabIndex = 19;
            this.comConnect.Text = "Connect";
            this.comConnect.UseVisualStyleBackColor = true;
            this.comConnect.Click += new System.EventHandler(this.comConnect_Click);
            // 
            // comListRefresh
            // 
            this.comListRefresh.Location = new System.Drawing.Point(375, 12);
            this.comListRefresh.Name = "comListRefresh";
            this.comListRefresh.Size = new System.Drawing.Size(75, 23);
            this.comListRefresh.TabIndex = 17;
            this.comListRefresh.Text = "Refresh";
            this.comListRefresh.UseVisualStyleBackColor = true;
            this.comListRefresh.Click += new System.EventHandler(this.comListRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "COM Baud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "COM Port:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 270);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imageresolutionBox);
            this.tabPage1.Controls.Add(this.totalmotionBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tdecBox);
            this.tabPage1.Controls.Add(this.nimagesBox);
            this.tabPage1.Controls.Add(this.startpointBox);
            this.tabPage1.Controls.Add(this.b_AbortMotion);
            this.tabPage1.Controls.Add(this.b_sendConf);
            this.tabPage1.Controls.Add(this.b_MotionExecute);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(226, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Motion Commands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageresolutionBox
            // 
            this.imageresolutionBox.Location = new System.Drawing.Point(111, 141);
            this.imageresolutionBox.Name = "imageresolutionBox";
            this.imageresolutionBox.ReadOnly = true;
            this.imageresolutionBox.Size = new System.Drawing.Size(66, 20);
            this.imageresolutionBox.TabIndex = 5;
            // 
            // totalmotionBox
            // 
            this.totalmotionBox.Location = new System.Drawing.Point(111, 115);
            this.totalmotionBox.Name = "totalmotionBox";
            this.totalmotionBox.ReadOnly = true;
            this.totalmotionBox.Size = new System.Drawing.Size(66, 20);
            this.totalmotionBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Image Resolution:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trigger Decimation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "deg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "steps";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "images";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "steps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "deg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Motion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of Images:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Startpoint:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tdecBox
            // 
            this.tdecBox.Location = new System.Drawing.Point(125, 65);
            this.tdecBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tdecBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tdecBox.Name = "tdecBox";
            this.tdecBox.Size = new System.Drawing.Size(43, 20);
            this.tdecBox.TabIndex = 3;
            this.tdecBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tdecBox.ValueChanged += new System.EventHandler(this.startpointBox_ValueChanged);
            // 
            // nimagesBox
            // 
            this.nimagesBox.Location = new System.Drawing.Point(125, 39);
            this.nimagesBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nimagesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nimagesBox.Name = "nimagesBox";
            this.nimagesBox.Size = new System.Drawing.Size(43, 20);
            this.nimagesBox.TabIndex = 3;
            this.nimagesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nimagesBox.ValueChanged += new System.EventHandler(this.startpointBox_ValueChanged);
            // 
            // startpointBox
            // 
            this.startpointBox.Location = new System.Drawing.Point(125, 13);
            this.startpointBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.startpointBox.Name = "startpointBox";
            this.startpointBox.Size = new System.Drawing.Size(43, 20);
            this.startpointBox.TabIndex = 3;
            this.startpointBox.ValueChanged += new System.EventHandler(this.startpointBox_ValueChanged);
            // 
            // b_AbortMotion
            // 
            this.b_AbortMotion.Enabled = false;
            this.b_AbortMotion.Location = new System.Drawing.Point(148, 189);
            this.b_AbortMotion.Name = "b_AbortMotion";
            this.b_AbortMotion.Size = new System.Drawing.Size(65, 42);
            this.b_AbortMotion.TabIndex = 0;
            this.b_AbortMotion.Text = "Abort\r\nMotion";
            this.b_AbortMotion.UseVisualStyleBackColor = true;
            this.b_AbortMotion.Click += new System.EventHandler(this.b_AbortMotion_Click);
            // 
            // b_sendConf
            // 
            this.b_sendConf.Enabled = false;
            this.b_sendConf.Location = new System.Drawing.Point(6, 189);
            this.b_sendConf.Name = "b_sendConf";
            this.b_sendConf.Size = new System.Drawing.Size(65, 42);
            this.b_sendConf.TabIndex = 0;
            this.b_sendConf.Text = "Send\r\nConfig";
            this.b_sendConf.UseVisualStyleBackColor = true;
            this.b_sendConf.Click += new System.EventHandler(this.b_sendConf_Click);
            // 
            // b_MotionExecute
            // 
            this.b_MotionExecute.Enabled = false;
            this.b_MotionExecute.Location = new System.Drawing.Point(77, 189);
            this.b_MotionExecute.Name = "b_MotionExecute";
            this.b_MotionExecute.Size = new System.Drawing.Size(65, 42);
            this.b_MotionExecute.TabIndex = 0;
            this.b_MotionExecute.Text = "Execute\r\nMotion";
            this.b_MotionExecute.UseVisualStyleBackColor = true;
            this.b_MotionExecute.Click += new System.EventHandler(this.b_MotionExecute_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.d_release);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.pHoldBox);
            this.tabPage2.Controls.Add(this.t2Box);
            this.tabPage2.Controls.Add(this.t1Box);
            this.tabPage2.Controls.Add(this.d_pHoldSet);
            this.tabPage2.Controls.Add(this.d_t2Set);
            this.tabPage2.Controls.Add(this.d_t1Set);
            this.tabPage2.Controls.Add(this.d_trigTest);
            this.tabPage2.Controls.Add(this.d_comTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(226, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diagnostic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // d_release
            // 
            this.d_release.Enabled = false;
            this.d_release.Location = new System.Drawing.Point(112, 151);
            this.d_release.Name = "d_release";
            this.d_release.Size = new System.Drawing.Size(108, 23);
            this.d_release.TabIndex = 4;
            this.d_release.Text = "Release";
            this.d_release.UseVisualStyleBackColor = true;
            this.d_release.Click += new System.EventHandler(this.b_AbortMotion_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Move + Hold [step]:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Step Delay [ms]:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Trigger Delay [ms]:";
            // 
            // pHoldBox
            // 
            this.pHoldBox.Location = new System.Drawing.Point(112, 125);
            this.pHoldBox.Name = "pHoldBox";
            this.pHoldBox.Size = new System.Drawing.Size(68, 20);
            this.pHoldBox.TabIndex = 2;
            this.pHoldBox.ThousandsSeparator = true;
            // 
            // t2Box
            // 
            this.t2Box.DecimalPlaces = 1;
            this.t2Box.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.t2Box.Location = new System.Drawing.Point(112, 96);
            this.t2Box.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            65536});
            this.t2Box.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.t2Box.Name = "t2Box";
            this.t2Box.Size = new System.Drawing.Size(68, 20);
            this.t2Box.TabIndex = 2;
            this.t2Box.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // t1Box
            // 
            this.t1Box.DecimalPlaces = 1;
            this.t1Box.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.t1Box.Location = new System.Drawing.Point(112, 67);
            this.t1Box.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            65536});
            this.t1Box.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.t1Box.Name = "t1Box";
            this.t1Box.Size = new System.Drawing.Size(68, 20);
            this.t1Box.TabIndex = 2;
            this.t1Box.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // d_pHoldSet
            // 
            this.d_pHoldSet.Enabled = false;
            this.d_pHoldSet.Location = new System.Drawing.Point(186, 122);
            this.d_pHoldSet.Name = "d_pHoldSet";
            this.d_pHoldSet.Size = new System.Drawing.Size(34, 23);
            this.d_pHoldSet.TabIndex = 1;
            this.d_pHoldSet.Text = "Set";
            this.d_pHoldSet.UseVisualStyleBackColor = true;
            this.d_pHoldSet.Click += new System.EventHandler(this.d_pHoldSet_Click);
            // 
            // d_t2Set
            // 
            this.d_t2Set.Enabled = false;
            this.d_t2Set.Location = new System.Drawing.Point(186, 93);
            this.d_t2Set.Name = "d_t2Set";
            this.d_t2Set.Size = new System.Drawing.Size(34, 23);
            this.d_t2Set.TabIndex = 1;
            this.d_t2Set.Text = "Set";
            this.d_t2Set.UseVisualStyleBackColor = true;
            this.d_t2Set.Click += new System.EventHandler(this.d_t2Set_Click);
            // 
            // d_t1Set
            // 
            this.d_t1Set.Enabled = false;
            this.d_t1Set.Location = new System.Drawing.Point(186, 64);
            this.d_t1Set.Name = "d_t1Set";
            this.d_t1Set.Size = new System.Drawing.Size(34, 23);
            this.d_t1Set.TabIndex = 1;
            this.d_t1Set.Text = "Set";
            this.d_t1Set.UseVisualStyleBackColor = true;
            this.d_t1Set.Click += new System.EventHandler(this.d_t1Set_Click);
            // 
            // d_trigTest
            // 
            this.d_trigTest.Enabled = false;
            this.d_trigTest.Location = new System.Drawing.Point(6, 35);
            this.d_trigTest.Name = "d_trigTest";
            this.d_trigTest.Size = new System.Drawing.Size(214, 23);
            this.d_trigTest.TabIndex = 0;
            this.d_trigTest.Text = "TRG Test";
            this.d_trigTest.UseVisualStyleBackColor = true;
            this.d_trigTest.Click += new System.EventHandler(this.d_trigTest_Click);
            // 
            // d_comTest
            // 
            this.d_comTest.Enabled = false;
            this.d_comTest.Location = new System.Drawing.Point(6, 6);
            this.d_comTest.Name = "d_comTest";
            this.d_comTest.Size = new System.Drawing.Size(214, 23);
            this.d_comTest.TabIndex = 0;
            this.d_comTest.Text = "COM Test";
            this.d_comTest.UseVisualStyleBackColor = true;
            this.d_comTest.Click += new System.EventHandler(this.d_comTest_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 356);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.baudBox);
            this.Controls.Add(this.ManualCommandBox);
            this.Controls.Add(this.CommandHistoryBox);
            this.Controls.Add(this.cb_comPortList);
            this.Controls.Add(this.b_manualCommandSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comDisconnect);
            this.Controls.Add(this.comConnect);
            this.Controls.Add(this.comListRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(559, 395);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Zero-Vis Teststand Interface";
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdecBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nimagesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startpointBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHoldBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown baudBox;
        private System.Windows.Forms.TextBox ManualCommandBox;
        private System.Windows.Forms.TextBox CommandHistoryBox;
        private System.Windows.Forms.ComboBox cb_comPortList;
        private System.Windows.Forms.Button b_manualCommandSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button comDisconnect;
        private System.Windows.Forms.Button comConnect;
        private System.Windows.Forms.Button comListRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox imageresolutionBox;
        private System.Windows.Forms.TextBox totalmotionBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tdecBox;
        private System.Windows.Forms.NumericUpDown nimagesBox;
        private System.Windows.Forms.NumericUpDown startpointBox;
        private System.Windows.Forms.Button b_AbortMotion;
        private System.Windows.Forms.Button b_sendConf;
        private System.Windows.Forms.Button b_MotionExecute;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button d_release;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown pHoldBox;
        private System.Windows.Forms.NumericUpDown t2Box;
        private System.Windows.Forms.NumericUpDown t1Box;
        private System.Windows.Forms.Button d_pHoldSet;
        private System.Windows.Forms.Button d_t2Set;
        private System.Windows.Forms.Button d_t1Set;
        private System.Windows.Forms.Button d_trigTest;
        private System.Windows.Forms.Button d_comTest;
    }
}

