namespace Powercheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelIpAdress = new System.Windows.Forms.Label();
            this.numericUpDownKeepAlive = new System.Windows.Forms.NumericUpDown();
            this.labelKeepAlive = new System.Windows.Forms.Label();
            this.numericUpDownTries = new System.Windows.Forms.NumericUpDown();
            this.labelNumberofTries = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownPingTimer = new System.Windows.Forms.NumericUpDown();
            this.labelPingTimer = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.checkBoxStartStopp = new System.Windows.Forms.CheckBox();
            this.labelPingResult = new System.Windows.Forms.Label();
            this.labelPingFail = new System.Windows.Forms.Label();
            this.panelNumeric = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.systemTrayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTrayicon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeepAlive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimer)).BeginInit();
            this.panelNumeric.SuspendLayout();
            this.contextMenuStripTrayicon.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(108, 14);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(273, 22);
            this.textBoxHost.TabIndex = 0;
            // 
            // labelIpAdress
            // 
            this.labelIpAdress.AutoSize = true;
            this.labelIpAdress.Location = new System.Drawing.Point(12, 17);
            this.labelIpAdress.Name = "labelIpAdress";
            this.labelIpAdress.Size = new System.Drawing.Size(88, 17);
            this.labelIpAdress.TabIndex = 1;
            this.labelIpAdress.Text = "Host to ping:";
            // 
            // numericUpDownKeepAlive
            // 
            this.numericUpDownKeepAlive.Location = new System.Drawing.Point(19, 11);
            this.numericUpDownKeepAlive.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownKeepAlive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKeepAlive.Name = "numericUpDownKeepAlive";
            this.numericUpDownKeepAlive.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownKeepAlive.TabIndex = 2;
            this.numericUpDownKeepAlive.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelKeepAlive
            // 
            this.labelKeepAlive.AutoSize = true;
            this.labelKeepAlive.Location = new System.Drawing.Point(14, 86);
            this.labelKeepAlive.Name = "labelKeepAlive";
            this.labelKeepAlive.Size = new System.Drawing.Size(253, 17);
            this.labelKeepAlive.TabIndex = 3;
            this.labelKeepAlive.Text = "Shutdown after power failure (1-5min): ";
            // 
            // numericUpDownTries
            // 
            this.numericUpDownTries.Location = new System.Drawing.Point(19, 39);
            this.numericUpDownTries.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTries.Name = "numericUpDownTries";
            this.numericUpDownTries.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownTries.TabIndex = 4;
            this.numericUpDownTries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumberofTries
            // 
            this.labelNumberofTries.AutoSize = true;
            this.labelNumberofTries.Location = new System.Drawing.Point(14, 114);
            this.labelNumberofTries.Name = "labelNumberofTries";
            this.labelNumberofTries.Size = new System.Drawing.Size(187, 17);
            this.labelNumberofTries.TabIndex = 5;
            this.labelNumberofTries.Text = "Allowable ping failures (1-5):";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 172);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownPingTimer
            // 
            this.numericUpDownPingTimer.Location = new System.Drawing.Point(19, 67);
            this.numericUpDownPingTimer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPingTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPingTimer.Name = "numericUpDownPingTimer";
            this.numericUpDownPingTimer.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownPingTimer.TabIndex = 9;
            this.numericUpDownPingTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPingTimer
            // 
            this.labelPingTimer.AutoSize = true;
            this.labelPingTimer.Location = new System.Drawing.Point(14, 142);
            this.labelPingTimer.Name = "labelPingTimer";
            this.labelPingTimer.Size = new System.Drawing.Size(231, 17);
            this.labelPingTimer.TabIndex = 10;
            this.labelPingTimer.Text = "Minutes between checks (1-10min):";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(15, 43);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(70, 30);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // checkBoxStartStopp
            // 
            this.checkBoxStartStopp.AutoSize = true;
            this.checkBoxStartStopp.Location = new System.Drawing.Point(280, 173);
            this.checkBoxStartStopp.Name = "checkBoxStartStopp";
            this.checkBoxStartStopp.Size = new System.Drawing.Size(101, 21);
            this.checkBoxStartStopp.TabIndex = 12;
            this.checkBoxStartStopp.Text = "Start/Stopp";
            this.checkBoxStartStopp.UseVisualStyleBackColor = true;
            this.checkBoxStartStopp.CheckStateChanged += new System.EventHandler(this.checkBoxStartStopp_CheckStateChanged);
            // 
            // labelPingResult
            // 
            this.labelPingResult.AutoSize = true;
            this.labelPingResult.Location = new System.Drawing.Point(110, 51);
            this.labelPingResult.Name = "labelPingResult";
            this.labelPingResult.Size = new System.Drawing.Size(0, 17);
            this.labelPingResult.TabIndex = 13;
            // 
            // labelPingFail
            // 
            this.labelPingFail.AutoSize = true;
            this.labelPingFail.Location = new System.Drawing.Point(269, 51);
            this.labelPingFail.Name = "labelPingFail";
            this.labelPingFail.Size = new System.Drawing.Size(0, 17);
            this.labelPingFail.TabIndex = 14;
            // 
            // panelNumeric
            // 
            this.panelNumeric.Controls.Add(this.numericUpDownKeepAlive);
            this.panelNumeric.Controls.Add(this.numericUpDownTries);
            this.panelNumeric.Controls.Add(this.numericUpDownPingTimer);
            this.panelNumeric.Location = new System.Drawing.Point(290, 72);
            this.panelNumeric.Name = "panelNumeric";
            this.panelNumeric.Size = new System.Drawing.Size(94, 97);
            this.panelNumeric.TabIndex = 15;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(91, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 30);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Abort shutdown";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // systemTrayicon
            // 
            this.systemTrayicon.ContextMenuStrip = this.contextMenuStripTrayicon;
            this.systemTrayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayicon.Icon")));
            this.systemTrayicon.Text = "Powercheck";
            this.systemTrayicon.Visible = true;
            this.systemTrayicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systemTrayicon_MouseDoubleClick);
            // 
            // contextMenuStripTrayicon
            // 
            this.contextMenuStripTrayicon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTrayicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.abortShutdownToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStripTrayicon.Name = "contextMenuStripTrayicon";
            this.contextMenuStripTrayicon.Size = new System.Drawing.Size(191, 136);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // abortShutdownToolStripMenuItem
            // 
            this.abortShutdownToolStripMenuItem.Name = "abortShutdownToolStripMenuItem";
            this.abortShutdownToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.abortShutdownToolStripMenuItem.Text = "Abort shutdown";
            this.abortShutdownToolStripMenuItem.Click += new System.EventHandler(this.abortShutdownToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 213);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.panelNumeric);
            this.Controls.Add(this.labelPingFail);
            this.Controls.Add(this.labelPingResult);
            this.Controls.Add(this.checkBoxStartStopp);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.labelPingTimer);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelNumberofTries);
            this.Controls.Add(this.labelKeepAlive);
            this.Controls.Add(this.labelIpAdress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 260);
            this.MinimumSize = new System.Drawing.Size(415, 260);
            this.Name = "Form1";
            this.Text = "Powercheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeepAlive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimer)).EndInit();
            this.panelNumeric.ResumeLayout(false);
            this.contextMenuStripTrayicon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label labelIpAdress;
        private System.Windows.Forms.NumericUpDown numericUpDownKeepAlive;
        private System.Windows.Forms.Label labelKeepAlive;
        private System.Windows.Forms.NumericUpDown numericUpDownTries;
        private System.Windows.Forms.Label labelNumberofTries;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownPingTimer;
        private System.Windows.Forms.Label labelPingTimer;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.CheckBox checkBoxStartStopp;
        private System.Windows.Forms.Label labelPingResult;
        private System.Windows.Forms.Label labelPingFail;
        private System.Windows.Forms.Panel panelNumeric;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NotifyIcon systemTrayicon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTrayicon;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abortShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

