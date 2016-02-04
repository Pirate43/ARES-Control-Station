namespace ControlStation
{
    partial class MainWindow
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
                socket.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConsoleLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.TextBox();
            this.labelConsole = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.transportGroup = new System.Windows.Forms.GroupBox();
            this.lblLowerBot = new System.Windows.Forms.Label();
            this.lblRaiseBot = new System.Windows.Forms.Label();
            this.goBackward = new FontAwesomeIcons.IconButton();
            this.turnCW = new FontAwesomeIcons.IconButton();
            this.goForward = new FontAwesomeIcons.IconButton();
            this.turnCCW = new FontAwesomeIcons.IconButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lowerBot = new FontAwesomeIcons.IconButton();
            this.raiseBot = new FontAwesomeIcons.IconButton();
            this.miningGroup = new System.Windows.Forms.GroupBox();
            this.lblFront = new System.Windows.Forms.Label();
            this.lblRear = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDump = new System.Windows.Forms.Label();
            this.lower_f = new FontAwesomeIcons.IconButton();
            this.raise_f = new FontAwesomeIcons.IconButton();
            this.dump_f = new FontAwesomeIcons.IconButton();
            this.mine_f = new FontAwesomeIcons.IconButton();
            this.dump_r = new FontAwesomeIcons.IconButton();
            this.raise_r = new FontAwesomeIcons.IconButton();
            this.mine_r = new FontAwesomeIcons.IconButton();
            this.lower_r = new FontAwesomeIcons.IconButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.disconnectButton = new FontAwesomeIcons.IconButton();
            this.miscGroup = new System.Windows.Forms.GroupBox();
            this.lblGamepad = new System.Windows.Forms.Label();
            this.gamepadButton = new FontAwesomeIcons.IconButton();
            this.lblDisconnect = new System.Windows.Forms.Label();
            this.txtCustomCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.labelBatteryVolts = new System.Windows.Forms.Label();
            this.lblSignal = new System.Windows.Forms.Label();
            this.lblSignalValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.transportGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCCW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raiseBot)).BeginInit();
            this.miningGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lower_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raise_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dump_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dump_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raise_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButton)).BeginInit();
            this.miscGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamepadButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConsoleLogsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveConsoleLogsToolStripMenuItem
            // 
            this.saveConsoleLogsToolStripMenuItem.Name = "saveConsoleLogsToolStripMenuItem";
            this.saveConsoleLogsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveConsoleLogsToolStripMenuItem.Text = "Save console logs...";
            this.saveConsoleLogsToolStripMenuItem.Click += new System.EventHandler(this.saveConsoleLogsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textboxIP
            // 
            this.textboxIP.Location = new System.Drawing.Point(59, 34);
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.Size = new System.Drawing.Size(114, 20);
            this.textboxIP.TabIndex = 4;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(5, 37);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(52, 13);
            this.labelIP.TabIndex = 5;
            this.labelIP.Text = "Robot IP:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(179, 32);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(58, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(261, 51);
            this.console.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.console.MaxLength = 99999;
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(511, 402);
            this.console.TabIndex = 7;
            this.console.TabStop = false;
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Location = new System.Drawing.Point(258, 35);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(48, 13);
            this.labelConsole.TabIndex = 8;
            this.labelConsole.Text = "Console:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "log";
            this.saveFileDialog1.Filter = "Log files|*.log|All Files|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // transportGroup
            // 
            this.transportGroup.Controls.Add(this.lblLowerBot);
            this.transportGroup.Controls.Add(this.lblRaiseBot);
            this.transportGroup.Controls.Add(this.goBackward);
            this.transportGroup.Controls.Add(this.turnCW);
            this.transportGroup.Controls.Add(this.goForward);
            this.transportGroup.Controls.Add(this.turnCCW);
            this.transportGroup.Controls.Add(this.splitter1);
            this.transportGroup.Controls.Add(this.lowerBot);
            this.transportGroup.Controls.Add(this.raiseBot);
            this.transportGroup.Enabled = false;
            this.transportGroup.Location = new System.Drawing.Point(8, 60);
            this.transportGroup.Name = "transportGroup";
            this.transportGroup.Size = new System.Drawing.Size(227, 132);
            this.transportGroup.TabIndex = 13;
            this.transportGroup.TabStop = false;
            this.transportGroup.Text = "Transport";
            // 
            // lblLowerBot
            // 
            this.lblLowerBot.AutoSize = true;
            this.lblLowerBot.Location = new System.Drawing.Point(184, 115);
            this.lblLowerBot.Name = "lblLowerBot";
            this.lblLowerBot.Size = new System.Drawing.Size(36, 13);
            this.lblLowerBot.TabIndex = 20;
            this.lblLowerBot.Text = "Lower";
            // 
            // lblRaiseBot
            // 
            this.lblRaiseBot.AutoSize = true;
            this.lblRaiseBot.Location = new System.Drawing.Point(184, 12);
            this.lblRaiseBot.Name = "lblRaiseBot";
            this.lblRaiseBot.Size = new System.Drawing.Size(34, 13);
            this.lblRaiseBot.TabIndex = 16;
            this.lblRaiseBot.Text = "Raise";
            // 
            // goBackward
            // 
            this.goBackward.ActiveColor = System.Drawing.Color.Black;
            this.goBackward.BackColor = System.Drawing.Color.Transparent;
            this.goBackward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goBackward.IconType = FontAwesomeIcons.IconType.ArrowDown;
            this.goBackward.InActiveColor = System.Drawing.Color.DimGray;
            this.goBackward.Location = new System.Drawing.Point(57, 83);
            this.goBackward.Name = "goBackward";
            this.goBackward.Size = new System.Drawing.Size(39, 44);
            this.goBackward.TabIndex = 19;
            this.goBackward.TabStop = false;
            this.goBackward.ToolTipText = null;
            this.goBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.goBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // turnCW
            // 
            this.turnCW.ActiveColor = System.Drawing.Color.Black;
            this.turnCW.BackColor = System.Drawing.Color.Transparent;
            this.turnCW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnCW.IconType = FontAwesomeIcons.IconType.Repeat;
            this.turnCW.InActiveColor = System.Drawing.Color.DimGray;
            this.turnCW.Location = new System.Drawing.Point(102, 49);
            this.turnCW.Name = "turnCW";
            this.turnCW.Size = new System.Drawing.Size(39, 44);
            this.turnCW.TabIndex = 16;
            this.turnCW.TabStop = false;
            this.turnCW.ToolTipText = null;
            this.turnCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.turnCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // goForward
            // 
            this.goForward.ActiveColor = System.Drawing.Color.Black;
            this.goForward.BackColor = System.Drawing.Color.Transparent;
            this.goForward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goForward.IconType = FontAwesomeIcons.IconType.ArrowUp;
            this.goForward.InActiveColor = System.Drawing.Color.DimGray;
            this.goForward.Location = new System.Drawing.Point(57, 19);
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(39, 44);
            this.goForward.TabIndex = 18;
            this.goForward.TabStop = false;
            this.goForward.ToolTipText = null;
            this.goForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.goForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // turnCCW
            // 
            this.turnCCW.ActiveColor = System.Drawing.Color.Black;
            this.turnCCW.BackColor = System.Drawing.Color.Transparent;
            this.turnCCW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnCCW.IconType = FontAwesomeIcons.IconType.RotateLeft;
            this.turnCCW.InActiveColor = System.Drawing.Color.DimGray;
            this.turnCCW.Location = new System.Drawing.Point(11, 49);
            this.turnCCW.Name = "turnCCW";
            this.turnCCW.Size = new System.Drawing.Size(39, 44);
            this.turnCCW.TabIndex = 17;
            this.turnCCW.TabStop = false;
            this.turnCCW.ToolTipText = null;
            this.turnCCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.turnCCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(148, 113);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // lowerBot
            // 
            this.lowerBot.ActiveColor = System.Drawing.Color.Black;
            this.lowerBot.BackColor = System.Drawing.Color.Transparent;
            this.lowerBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerBot.IconType = FontAwesomeIcons.IconType.ArrowCircleODown;
            this.lowerBot.InActiveColor = System.Drawing.Color.DimGray;
            this.lowerBot.Location = new System.Drawing.Point(182, 71);
            this.lowerBot.Name = "lowerBot";
            this.lowerBot.Size = new System.Drawing.Size(39, 44);
            this.lowerBot.TabIndex = 14;
            this.lowerBot.TabStop = false;
            this.lowerBot.ToolTipText = null;
            this.lowerBot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lowerBot_mouseDown);
            this.lowerBot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lowerBot_mouseUp);
            // 
            // raiseBot
            // 
            this.raiseBot.ActiveColor = System.Drawing.Color.Black;
            this.raiseBot.BackColor = System.Drawing.Color.Transparent;
            this.raiseBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raiseBot.IconType = FontAwesomeIcons.IconType.ArrowCircleOUp;
            this.raiseBot.InActiveColor = System.Drawing.Color.DimGray;
            this.raiseBot.Location = new System.Drawing.Point(182, 26);
            this.raiseBot.Name = "raiseBot";
            this.raiseBot.Size = new System.Drawing.Size(39, 44);
            this.raiseBot.TabIndex = 13;
            this.raiseBot.TabStop = false;
            this.raiseBot.ToolTipText = null;
            this.raiseBot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.raiseBot_mouseDown);
            this.raiseBot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.raiseBot_mouseUp);
            // 
            // miningGroup
            // 
            this.miningGroup.Controls.Add(this.lblFront);
            this.miningGroup.Controls.Add(this.lblRear);
            this.miningGroup.Controls.Add(this.radioButton1);
            this.miningGroup.Controls.Add(this.label2);
            this.miningGroup.Controls.Add(this.lblDump);
            this.miningGroup.Controls.Add(this.lower_f);
            this.miningGroup.Controls.Add(this.raise_f);
            this.miningGroup.Controls.Add(this.dump_f);
            this.miningGroup.Controls.Add(this.mine_f);
            this.miningGroup.Controls.Add(this.dump_r);
            this.miningGroup.Controls.Add(this.raise_r);
            this.miningGroup.Controls.Add(this.mine_r);
            this.miningGroup.Controls.Add(this.lower_r);
            this.miningGroup.Enabled = false;
            this.miningGroup.Location = new System.Drawing.Point(8, 199);
            this.miningGroup.Name = "miningGroup";
            this.miningGroup.Size = new System.Drawing.Size(227, 146);
            this.miningGroup.TabIndex = 14;
            this.miningGroup.TabStop = false;
            this.miningGroup.Text = "Mining";
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(181, 74);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(44, 13);
            this.lblFront.TabIndex = 23;
            this.lblFront.Text = "FRONT";
            // 
            // lblRear
            // 
            this.lblRear.AutoSize = true;
            this.lblRear.Location = new System.Drawing.Point(9, 74);
            this.lblRear.Name = "lblRear";
            this.lblRear.Size = new System.Drawing.Size(37, 13);
            this.lblRear.TabIndex = 22;
            this.lblRear.Text = "REAR";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(77, -2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dual-mode";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mine                     Mine";
            // 
            // lblDump
            // 
            this.lblDump.AutoSize = true;
            this.lblDump.Location = new System.Drawing.Point(48, 127);
            this.lblDump.Name = "lblDump";
            this.lblDump.Size = new System.Drawing.Size(123, 13);
            this.lblDump.TabIndex = 19;
            this.lblDump.Text = " Dump                   Dump";
            // 
            // lower_f
            // 
            this.lower_f.ActiveColor = System.Drawing.Color.Black;
            this.lower_f.BackColor = System.Drawing.Color.Transparent;
            this.lower_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lower_f.IconType = FontAwesomeIcons.IconType.ChevronCircleDown;
            this.lower_f.InActiveColor = System.Drawing.Color.DimGray;
            this.lower_f.Location = new System.Drawing.Point(182, 100);
            this.lower_f.Name = "lower_f";
            this.lower_f.Size = new System.Drawing.Size(40, 40);
            this.lower_f.TabIndex = 18;
            this.lower_f.TabStop = false;
            this.lower_f.ToolTipText = null;
            // 
            // raise_f
            // 
            this.raise_f.ActiveColor = System.Drawing.Color.Black;
            this.raise_f.BackColor = System.Drawing.Color.Transparent;
            this.raise_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raise_f.IconType = FontAwesomeIcons.IconType.ChevronCircleUp;
            this.raise_f.InActiveColor = System.Drawing.Color.DimGray;
            this.raise_f.Location = new System.Drawing.Point(181, 19);
            this.raise_f.Name = "raise_f";
            this.raise_f.Size = new System.Drawing.Size(40, 40);
            this.raise_f.TabIndex = 17;
            this.raise_f.TabStop = false;
            this.raise_f.ToolTipText = null;
            // 
            // dump_f
            // 
            this.dump_f.ActiveColor = System.Drawing.Color.Black;
            this.dump_f.BackColor = System.Drawing.Color.Transparent;
            this.dump_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dump_f.IconType = FontAwesomeIcons.IconType.AngleDoubleDown;
            this.dump_f.InActiveColor = System.Drawing.Color.DimGray;
            this.dump_f.Location = new System.Drawing.Point(135, 85);
            this.dump_f.Name = "dump_f";
            this.dump_f.Size = new System.Drawing.Size(40, 40);
            this.dump_f.TabIndex = 16;
            this.dump_f.TabStop = false;
            this.dump_f.ToolTipText = null;
            // 
            // mine_f
            // 
            this.mine_f.ActiveColor = System.Drawing.Color.Black;
            this.mine_f.BackColor = System.Drawing.Color.Transparent;
            this.mine_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mine_f.IconType = FontAwesomeIcons.IconType.Cog;
            this.mine_f.InActiveColor = System.Drawing.Color.DimGray;
            this.mine_f.Location = new System.Drawing.Point(135, 39);
            this.mine_f.Name = "mine_f";
            this.mine_f.Size = new System.Drawing.Size(40, 40);
            this.mine_f.TabIndex = 15;
            this.mine_f.TabStop = false;
            this.mine_f.ToolTipText = null;
            // 
            // dump_r
            // 
            this.dump_r.ActiveColor = System.Drawing.Color.Black;
            this.dump_r.BackColor = System.Drawing.Color.Transparent;
            this.dump_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dump_r.IconType = FontAwesomeIcons.IconType.AngleDoubleDown;
            this.dump_r.InActiveColor = System.Drawing.Color.DimGray;
            this.dump_r.Location = new System.Drawing.Point(51, 85);
            this.dump_r.Name = "dump_r";
            this.dump_r.Size = new System.Drawing.Size(40, 40);
            this.dump_r.TabIndex = 14;
            this.dump_r.TabStop = false;
            this.dump_r.ToolTipText = null;
            this.dump_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.dump_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // raise_r
            // 
            this.raise_r.ActiveColor = System.Drawing.Color.Black;
            this.raise_r.BackColor = System.Drawing.Color.Transparent;
            this.raise_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raise_r.IconType = FontAwesomeIcons.IconType.ChevronCircleUp;
            this.raise_r.InActiveColor = System.Drawing.Color.DimGray;
            this.raise_r.Location = new System.Drawing.Point(6, 19);
            this.raise_r.Name = "raise_r";
            this.raise_r.Size = new System.Drawing.Size(40, 40);
            this.raise_r.TabIndex = 13;
            this.raise_r.TabStop = false;
            this.raise_r.ToolTipText = null;
            this.raise_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.raise_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // mine_r
            // 
            this.mine_r.ActiveColor = System.Drawing.Color.Black;
            this.mine_r.BackColor = System.Drawing.Color.Transparent;
            this.mine_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mine_r.IconType = FontAwesomeIcons.IconType.Cog;
            this.mine_r.InActiveColor = System.Drawing.Color.DimGray;
            this.mine_r.Location = new System.Drawing.Point(51, 39);
            this.mine_r.Name = "mine_r";
            this.mine_r.Size = new System.Drawing.Size(40, 40);
            this.mine_r.TabIndex = 12;
            this.mine_r.TabStop = false;
            this.mine_r.ToolTipText = null;
            this.mine_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.mine_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lower_r
            // 
            this.lower_r.ActiveColor = System.Drawing.Color.Black;
            this.lower_r.BackColor = System.Drawing.Color.Transparent;
            this.lower_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lower_r.IconType = FontAwesomeIcons.IconType.ChevronCircleDown;
            this.lower_r.InActiveColor = System.Drawing.Color.DimGray;
            this.lower_r.Location = new System.Drawing.Point(6, 100);
            this.lower_r.Name = "lower_r";
            this.lower_r.Size = new System.Drawing.Size(40, 40);
            this.lower_r.TabIndex = 11;
            this.lower_r.TabStop = false;
            this.lower_r.ToolTipText = null;
            this.lower_r.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.lower_r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 488);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // disconnectButton
            // 
            this.disconnectButton.ActiveColor = System.Drawing.Color.Maroon;
            this.disconnectButton.BackColor = System.Drawing.Color.Silver;
            this.disconnectButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.IconType = FontAwesomeIcons.IconType.MinusCircle;
            this.disconnectButton.InActiveColor = System.Drawing.Color.DimGray;
            this.disconnectButton.Location = new System.Drawing.Point(8, 19);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(40, 40);
            this.disconnectButton.TabIndex = 16;
            this.disconnectButton.TabStop = false;
            this.disconnectButton.ToolTipText = null;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            this.disconnectButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.disconnectButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // miscGroup
            // 
            this.miscGroup.Controls.Add(this.lblGamepad);
            this.miscGroup.Controls.Add(this.gamepadButton);
            this.miscGroup.Controls.Add(this.lblDisconnect);
            this.miscGroup.Controls.Add(this.disconnectButton);
            this.miscGroup.Location = new System.Drawing.Point(10, 353);
            this.miscGroup.Name = "miscGroup";
            this.miscGroup.Size = new System.Drawing.Size(227, 79);
            this.miscGroup.TabIndex = 17;
            this.miscGroup.TabStop = false;
            this.miscGroup.Text = "Misc Actions";
            // 
            // lblGamepad
            // 
            this.lblGamepad.AutoSize = true;
            this.lblGamepad.Location = new System.Drawing.Point(49, 62);
            this.lblGamepad.Name = "lblGamepad";
            this.lblGamepad.Size = new System.Drawing.Size(53, 13);
            this.lblGamepad.TabIndex = 18;
            this.lblGamepad.Text = "Gamepad";
            // 
            // gamepadButton
            // 
            this.gamepadButton.ActiveColor = System.Drawing.Color.Black;
            this.gamepadButton.BackColor = System.Drawing.Color.Transparent;
            this.gamepadButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamepadButton.IconType = FontAwesomeIcons.IconType.Gamepad;
            this.gamepadButton.InActiveColor = System.Drawing.Color.DimGray;
            this.gamepadButton.Location = new System.Drawing.Point(54, 19);
            this.gamepadButton.Margin = new System.Windows.Forms.Padding(0);
            this.gamepadButton.Name = "gamepadButton";
            this.gamepadButton.Size = new System.Drawing.Size(40, 40);
            this.gamepadButton.TabIndex = 17;
            this.gamepadButton.TabStop = false;
            this.gamepadButton.ToolTipText = null;
            this.gamepadButton.Click += new System.EventHandler(this.gamepadButton_Click);
            // 
            // lblDisconnect
            // 
            this.lblDisconnect.AutoSize = true;
            this.lblDisconnect.Location = new System.Drawing.Point(17, 62);
            this.lblDisconnect.Name = "lblDisconnect";
            this.lblDisconnect.Size = new System.Drawing.Size(24, 13);
            this.lblDisconnect.TabIndex = 16;
            this.lblDisconnect.Text = "d/c";
            // 
            // txtCustomCommand
            // 
            this.txtCustomCommand.Location = new System.Drawing.Point(353, 460);
            this.txtCustomCommand.Name = "txtCustomCommand";
            this.txtCustomCommand.Size = new System.Drawing.Size(419, 20);
            this.txtCustomCommand.TabIndex = 18;
            this.txtCustomCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendCustomCommand);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Custom command:";
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(8, 440);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(46, 13);
            this.lblBattery.TabIndex = 21;
            this.lblBattery.Text = "Battery: ";
            // 
            // labelBatteryVolts
            // 
            this.labelBatteryVolts.AutoSize = true;
            this.labelBatteryVolts.Location = new System.Drawing.Point(51, 440);
            this.labelBatteryVolts.Name = "labelBatteryVolts";
            this.labelBatteryVolts.Size = new System.Drawing.Size(10, 13);
            this.labelBatteryVolts.TabIndex = 22;
            this.labelBatteryVolts.Text = "-";
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Location = new System.Drawing.Point(8, 456);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(42, 13);
            this.lblSignal.TabIndex = 23;
            this.lblSignal.Text = "Signal: ";
            // 
            // lblSignalValue
            // 
            this.lblSignalValue.AutoSize = true;
            this.lblSignalValue.Location = new System.Drawing.Point(51, 456);
            this.lblSignalValue.Name = "lblSignalValue";
            this.lblSignalValue.Size = new System.Drawing.Size(10, 13);
            this.lblSignalValue.TabIndex = 24;
            this.lblSignalValue.Text = "-";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 510);
            this.Controls.Add(this.lblSignalValue);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.labelBatteryVolts);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomCommand);
            this.Controls.Add(this.miscGroup);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.miningGroup);
            this.Controls.Add(this.transportGroup);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.console);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textboxIP);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 549);
            this.MinimumSize = new System.Drawing.Size(800, 549);
            this.Name = "MainWindow";
            this.Text = "ARES Control Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.transportGroup.ResumeLayout(false);
            this.transportGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCCW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raiseBot)).EndInit();
            this.miningGroup.ResumeLayout(false);
            this.miningGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lower_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raise_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dump_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dump_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raise_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mine_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButton)).EndInit();
            this.miscGroup.ResumeLayout(false);
            this.miscGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamepadButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textboxIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.ToolStripMenuItem saveConsoleLogsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox transportGroup;
        private System.Windows.Forms.GroupBox miningGroup;
        private FontAwesomeIcons.IconButton dump_r;
        private FontAwesomeIcons.IconButton raise_r;
        private FontAwesomeIcons.IconButton mine_r;
        private FontAwesomeIcons.IconButton lower_r;
        private System.Windows.Forms.StatusStrip statusStrip;
        private FontAwesomeIcons.IconButton disconnectButton;
        private System.Windows.Forms.GroupBox miscGroup;
        private System.Windows.Forms.Label lblDisconnect;
        private FontAwesomeIcons.IconButton gamepadButton;
        private System.Windows.Forms.Label lblGamepad;
        private System.Windows.Forms.TextBox txtCustomCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLowerBot;
        private System.Windows.Forms.Label lblRaiseBot;
        private FontAwesomeIcons.IconButton goBackward;
        private FontAwesomeIcons.IconButton turnCW;
        private FontAwesomeIcons.IconButton goForward;
        private FontAwesomeIcons.IconButton turnCCW;
        private System.Windows.Forms.Splitter splitter1;
        private FontAwesomeIcons.IconButton lowerBot;
        private FontAwesomeIcons.IconButton raiseBot;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label labelBatteryVolts;
        private FontAwesomeIcons.IconButton lower_f;
        private FontAwesomeIcons.IconButton raise_f;
        private FontAwesomeIcons.IconButton dump_f;
        private FontAwesomeIcons.IconButton mine_f;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDump;
        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.Label lblRear;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Label lblSignalValue;
    }
}

