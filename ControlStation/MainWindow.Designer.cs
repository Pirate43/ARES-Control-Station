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
            this.miscGroup = new System.Windows.Forms.GroupBox();
            this.lblDisconnect = new System.Windows.Forms.Label();
            this.gamepadButton = new FontAwesomeIcons.IconButton();
            this.lblGamepad = new System.Windows.Forms.Label();
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
            this.textboxIP.Location = new System.Drawing.Point(59, 34);
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.Size = new System.Drawing.Size(100, 20);
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
            this.buttonConnect.Location = new System.Drawing.Point(162, 32);
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
            this.console.Location = new System.Drawing.Point(261, 51);
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
            this.transportGroup.Controls.Add(this.goBackward);
            this.transportGroup.Controls.Add(this.turnCW);
            this.transportGroup.Controls.Add(this.goForward);
            this.transportGroup.Controls.Add(this.turnCCW);
            this.transportGroup.Enabled = false;
            this.transportGroup.Location = new System.Drawing.Point(8, 60);
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
            this.goBackward.Location = new System.Drawing.Point(56, 79);
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
            this.turnCW.Location = new System.Drawing.Point(101, 45);
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
            this.goForward.Location = new System.Drawing.Point(56, 15);
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
            this.turnCCW.Location = new System.Drawing.Point(10, 45);
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
            this.miningGroup.Enabled = false;
            this.miningGroup.Location = new System.Drawing.Point(8, 202);
            this.miningGroup.Name = "miningGroup";
            this.miningGroup.Size = new System.Drawing.Size(227, 82);
            this.miningGroup.TabIndex = 14;
            this.miningGroup.TabStop = false;
            this.miningGroup.Text = "Mining";
            // 
            // labelDescriptions
            // 
            this.labelDescriptions.AutoSize = true;
            this.labelDescriptions.Location = new System.Drawing.Point(7, 62);
            this.labelDescriptions.Name = "labelDescriptions";
            this.labelDescriptions.Size = new System.Drawing.Size(177, 13);
            this.labelDescriptions.TabIndex = 15;
            this.labelDescriptions.Text = "  Lower     Mine       Raise       Dump";
            // 
            // doDump
            // 
            this.doDump.ActiveColor = System.Drawing.Color.Black;
            this.doDump.BackColor = System.Drawing.Color.Transparent;
            this.doDump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doDump.IconType = FontAwesomeIcons.IconType.AngleDoubleDown;
            this.doDump.InActiveColor = System.Drawing.Color.DimGray;
            this.doDump.Location = new System.Drawing.Point(145, 19);
            this.doDump.Name = "doDump";
            this.doDump.Size = new System.Drawing.Size(40, 40);
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
            this.raiseMining.Location = new System.Drawing.Point(100, 19);
            this.raiseMining.Name = "raiseMining";
            this.raiseMining.Size = new System.Drawing.Size(40, 40);
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
            this.doMining.Location = new System.Drawing.Point(55, 19);
            this.doMining.Name = "doMining";
            this.doMining.Size = new System.Drawing.Size(40, 40);
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
            this.lowerMining.Location = new System.Drawing.Point(10, 19);
            this.lowerMining.Name = "lowerMining";
            this.lowerMining.Size = new System.Drawing.Size(40, 40);
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
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
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
            this.miscGroup.Location = new System.Drawing.Point(10, 298);
            this.miscGroup.Name = "miscGroup";
            this.miscGroup.Size = new System.Drawing.Size(227, 100);
            this.miscGroup.TabIndex = 17;
            this.miscGroup.TabStop = false;
            this.miscGroup.Text = "Misc Actions";
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
            // lblGamepad
            // 
            this.lblGamepad.AutoSize = true;
            this.lblGamepad.Location = new System.Drawing.Point(49, 62);
            this.lblGamepad.Name = "lblGamepad";
            this.lblGamepad.Size = new System.Drawing.Size(53, 13);
            this.lblGamepad.TabIndex = 18;
            this.lblGamepad.Text = "Gamepad";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 486);
            this.Controls.Add(this.miscGroup);
            this.Controls.Add(this.statusStrip1);
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
        private System.Windows.Forms.GroupBox miscGroup;
        private System.Windows.Forms.Label lblDisconnect;
        private FontAwesomeIcons.IconButton gamepadButton;
        private System.Windows.Forms.Label lblGamepad;
    }
}

