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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.goBackward = new FontAwesomeIcons.IconButton();
            this.turnCW = new FontAwesomeIcons.IconButton();
            this.goForward = new FontAwesomeIcons.IconButton();
            this.turnCCW = new FontAwesomeIcons.IconButton();
            this.miningGroup = new System.Windows.Forms.GroupBox();
            this.labelDescriptions = new System.Windows.Forms.Label();
            this.doDump = new FontAwesomeIcons.IconButton();
            this.raiseMining = new FontAwesomeIcons.IconButton();
            this.doMining = new FontAwesomeIcons.IconButton();
            this.lowerMining = new FontAwesomeIcons.IconButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.batteryBar = new System.Windows.Forms.ToolStripProgressBar();
            this.disconnectButton = new FontAwesomeIcons.IconButton();
            this.menuStrip1.SuspendLayout();
            this.transportGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCCW)).BeginInit();
            this.miningGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doDump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raiseMining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doMining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerMining)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sensor Value:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            this.textboxIP.Location = new System.Drawing.Point(63, 37);
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.Size = new System.Drawing.Size(100, 20);
            this.textboxIP.TabIndex = 4;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(8, 40);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(52, 13);
            this.labelIP.TabIndex = 5;
            this.labelIP.Text = "Robot IP:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(169, 35);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(264, 51);
            this.console.MaxLength = 99999;
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(274, 402);
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
            this.transportGroup.Controls.Add(this.goBackward);
            this.transportGroup.Controls.Add(this.turnCW);
            this.transportGroup.Controls.Add(this.goForward);
            this.transportGroup.Controls.Add(this.turnCCW);
            this.transportGroup.Location = new System.Drawing.Point(17, 65);
            this.transportGroup.Name = "transportGroup";
            this.transportGroup.Size = new System.Drawing.Size(227, 132);
            this.transportGroup.TabIndex = 13;
            this.transportGroup.TabStop = false;
            this.transportGroup.Text = "Transport";
            // 
            // goBackward
            // 
            this.goBackward.ActiveColor = System.Drawing.Color.Black;
            this.goBackward.BackColor = System.Drawing.Color.Transparent;
            this.goBackward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goBackward.IconType = FontAwesomeIcons.IconType.ArrowDown;
            this.goBackward.InActiveColor = System.Drawing.Color.DimGray;
            this.goBackward.Location = new System.Drawing.Point(93, 78);
            this.goBackward.Name = "goBackward";
            this.goBackward.Size = new System.Drawing.Size(39, 44);
            this.goBackward.TabIndex = 12;
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
            this.turnCW.Location = new System.Drawing.Point(152, 45);
            this.turnCW.Name = "turnCW";
            this.turnCW.Size = new System.Drawing.Size(39, 44);
            this.turnCW.TabIndex = 9;
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
            this.goForward.Location = new System.Drawing.Point(93, 14);
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(39, 44);
            this.goForward.TabIndex = 11;
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
            this.turnCCW.Location = new System.Drawing.Point(32, 45);
            this.turnCCW.Name = "turnCCW";
            this.turnCCW.Size = new System.Drawing.Size(39, 44);
            this.turnCCW.TabIndex = 10;
            this.turnCCW.TabStop = false;
            this.turnCCW.ToolTipText = null;
            this.turnCCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.turnCCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // miningGroup
            // 
            this.miningGroup.Controls.Add(this.labelDescriptions);
            this.miningGroup.Controls.Add(this.doDump);
            this.miningGroup.Controls.Add(this.raiseMining);
            this.miningGroup.Controls.Add(this.doMining);
            this.miningGroup.Controls.Add(this.lowerMining);
            this.miningGroup.Location = new System.Drawing.Point(17, 211);
            this.miningGroup.Name = "miningGroup";
            this.miningGroup.Size = new System.Drawing.Size(227, 100);
            this.miningGroup.TabIndex = 14;
            this.miningGroup.TabStop = false;
            this.miningGroup.Text = "Mining";
            // 
            // labelDescriptions
            // 
            this.labelDescriptions.AutoSize = true;
            this.labelDescriptions.Location = new System.Drawing.Point(17, 77);
            this.labelDescriptions.Name = "labelDescriptions";
            this.labelDescriptions.Size = new System.Drawing.Size(189, 13);
            this.labelDescriptions.TabIndex = 15;
            this.labelDescriptions.Text = "Lower        Mine         Raise        Dump";
            // 
            // doDump
            // 
            this.doDump.ActiveColor = System.Drawing.Color.Black;
            this.doDump.BackColor = System.Drawing.Color.Transparent;
            this.doDump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doDump.IconType = FontAwesomeIcons.IconType.AngleDoubleDown;
            this.doDump.InActiveColor = System.Drawing.Color.DimGray;
            this.doDump.Location = new System.Drawing.Point(170, 26);
            this.doDump.Name = "doDump";
            this.doDump.Size = new System.Drawing.Size(39, 44);
            this.doDump.TabIndex = 14;
            this.doDump.TabStop = false;
            this.doDump.ToolTipText = null;
            this.doDump.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.doDump.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // raiseMining
            // 
            this.raiseMining.ActiveColor = System.Drawing.Color.Black;
            this.raiseMining.BackColor = System.Drawing.Color.Transparent;
            this.raiseMining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raiseMining.IconType = FontAwesomeIcons.IconType.ChevronCircleUp;
            this.raiseMining.InActiveColor = System.Drawing.Color.DimGray;
            this.raiseMining.Location = new System.Drawing.Point(119, 26);
            this.raiseMining.Name = "raiseMining";
            this.raiseMining.Size = new System.Drawing.Size(39, 44);
            this.raiseMining.TabIndex = 13;
            this.raiseMining.TabStop = false;
            this.raiseMining.ToolTipText = null;
            this.raiseMining.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.raiseMining.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // doMining
            // 
            this.doMining.ActiveColor = System.Drawing.Color.Black;
            this.doMining.BackColor = System.Drawing.Color.Transparent;
            this.doMining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doMining.IconType = FontAwesomeIcons.IconType.Cog;
            this.doMining.InActiveColor = System.Drawing.Color.DimGray;
            this.doMining.Location = new System.Drawing.Point(68, 26);
            this.doMining.Name = "doMining";
            this.doMining.Size = new System.Drawing.Size(39, 44);
            this.doMining.TabIndex = 12;
            this.doMining.TabStop = false;
            this.doMining.ToolTipText = null;
            this.doMining.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.doMining.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lowerMining
            // 
            this.lowerMining.ActiveColor = System.Drawing.Color.Black;
            this.lowerMining.BackColor = System.Drawing.Color.Transparent;
            this.lowerMining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowerMining.IconType = FontAwesomeIcons.IconType.ChevronCircleDown;
            this.lowerMining.InActiveColor = System.Drawing.Color.DimGray;
            this.lowerMining.Location = new System.Drawing.Point(17, 26);
            this.lowerMining.Name = "lowerMining";
            this.lowerMining.Size = new System.Drawing.Size(39, 44);
            this.lowerMining.TabIndex = 11;
            this.lowerMining.TabStop = false;
            this.lowerMining.ToolTipText = null;
            this.lowerMining.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.lowerMining.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.batteryBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Battery:";
            // 
            // batteryBar
            // 
            this.batteryBar.Name = "batteryBar";
            this.batteryBar.Size = new System.Drawing.Size(100, 16);
            this.batteryBar.Step = -1;
            this.batteryBar.Value = 100;
            // 
            // disconnectButton
            // 
            this.disconnectButton.ActiveColor = System.Drawing.Color.Maroon;
            this.disconnectButton.BackColor = System.Drawing.Color.Silver;
            this.disconnectButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.IconType = FontAwesomeIcons.IconType.ChainBroken;
            this.disconnectButton.InActiveColor = System.Drawing.Color.DimGray;
            this.disconnectButton.Location = new System.Drawing.Point(213, 408);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(45, 45);
            this.disconnectButton.TabIndex = 16;
            this.disconnectButton.TabStop = false;
            this.disconnectButton.ToolTipText = null;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            this.disconnectButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.disconnectButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(544, 486);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.miningGroup);
            this.Controls.Add(this.transportGroup);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.console);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textboxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "ARES Control Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.transportGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnCCW)).EndInit();
            this.miningGroup.ResumeLayout(false);
            this.miningGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doDump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raiseMining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doMining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerMining)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
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
        private FontAwesomeIcons.IconButton turnCW;
        private FontAwesomeIcons.IconButton turnCCW;
        private FontAwesomeIcons.IconButton goForward;
        private FontAwesomeIcons.IconButton goBackward;
        private System.Windows.Forms.GroupBox transportGroup;
        private System.Windows.Forms.GroupBox miningGroup;
        private System.Windows.Forms.Label labelDescriptions;
        private FontAwesomeIcons.IconButton doDump;
        private FontAwesomeIcons.IconButton raiseMining;
        private FontAwesomeIcons.IconButton doMining;
        private FontAwesomeIcons.IconButton lowerMining;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar batteryBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private FontAwesomeIcons.IconButton disconnectButton;
    }
}

