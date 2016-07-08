namespace SerialCom
{
    partial class ServoCtrl
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
            this.CserialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnOpenOrClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CCbPortNo = new System.Windows.Forms.ComboBox();
            this.CCbCheckBit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCbStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CCbDataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CCbBaudrate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBtnRefreshPort = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbServoAngle = new System.Windows.Forms.GroupBox();
            this.lbServoAngle6 = new System.Windows.Forms.Label();
            this.lbServoAngle5 = new System.Windows.Forms.Label();
            this.lbServoAngle4 = new System.Windows.Forms.Label();
            this.lbServoAngle3 = new System.Windows.Forms.Label();
            this.lbServoAngle2 = new System.Windows.Forms.Label();
            this.lbServoAngle1 = new System.Windows.Forms.Label();
            this.hsbServo2 = new System.Windows.Forms.HScrollBar();
            this.hsbServo3 = new System.Windows.Forms.HScrollBar();
            this.hsbServo4 = new System.Windows.Forms.HScrollBar();
            this.hsbServo5 = new System.Windows.Forms.HScrollBar();
            this.hsbServo6 = new System.Windows.Forms.HScrollBar();
            this.hsbServo1 = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRecv = new System.Windows.Forms.TextBox();
            this.gbComSetting = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearRecv = new System.Windows.Forms.Button();
            this.cbDispMode = new System.Windows.Forms.ComboBox();
            this.timerDisp = new System.Windows.Forms.Timer(this.components);
            this.gbServoAngle.SuspendLayout();
            this.gbComSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // CserialPort
            // 
            this.CserialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnOpenOrClose
            // 
            this.btnOpenOrClose.Location = new System.Drawing.Point(23, 101);
            this.btnOpenOrClose.Name = "btnOpenOrClose";
            this.btnOpenOrClose.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOrClose.TabIndex = 1;
            this.btnOpenOrClose.Text = "打开串口";
            this.btnOpenOrClose.UseVisualStyleBackColor = true;
            this.btnOpenOrClose.Click += new System.EventHandler(this.btnOpenOrClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口号";
            // 
            // CCbPortNo
            // 
            this.CCbPortNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCbPortNo.FormattingEnabled = true;
            this.CCbPortNo.Location = new System.Drawing.Point(170, 26);
            this.CCbPortNo.Name = "CCbPortNo";
            this.CCbPortNo.Size = new System.Drawing.Size(69, 20);
            this.CCbPortNo.TabIndex = 4;
            // 
            // CCbCheckBit
            // 
            this.CCbCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCbCheckBit.FormattingEnabled = true;
            this.CCbCheckBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CCbCheckBit.Location = new System.Drawing.Point(170, 130);
            this.CCbCheckBit.Name = "CCbCheckBit";
            this.CCbCheckBit.Size = new System.Drawing.Size(69, 20);
            this.CCbCheckBit.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "校验位";
            // 
            // CCbStopBits
            // 
            this.CCbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCbStopBits.FormattingEnabled = true;
            this.CCbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CCbStopBits.Location = new System.Drawing.Point(170, 101);
            this.CCbStopBits.Name = "CCbStopBits";
            this.CCbStopBits.Size = new System.Drawing.Size(69, 20);
            this.CCbStopBits.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "停止位";
            // 
            // CCbDataBits
            // 
            this.CCbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCbDataBits.FormattingEnabled = true;
            this.CCbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CCbDataBits.Location = new System.Drawing.Point(170, 75);
            this.CCbDataBits.Name = "CCbDataBits";
            this.CCbDataBits.Size = new System.Drawing.Size(69, 20);
            this.CCbDataBits.Sorted = true;
            this.CCbDataBits.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据位";
            // 
            // CCbBaudrate
            // 
            this.CCbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCbBaudrate.FormattingEnabled = true;
            this.CCbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.CCbBaudrate.Location = new System.Drawing.Point(170, 49);
            this.CCbBaudrate.Name = "CCbBaudrate";
            this.CCbBaudrate.Size = new System.Drawing.Size(69, 20);
            this.CCbBaudrate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "波特率";
            // 
            // CBtnRefreshPort
            // 
            this.CBtnRefreshPort.Location = new System.Drawing.Point(23, 129);
            this.CBtnRefreshPort.Name = "CBtnRefreshPort";
            this.CBtnRefreshPort.Size = new System.Drawing.Size(75, 23);
            this.CBtnRefreshPort.TabIndex = 15;
            this.CBtnRefreshPort.Text = "刷新串口";
            this.CBtnRefreshPort.UseVisualStyleBackColor = true;
            this.CBtnRefreshPort.Click += new System.EventHandler(this.btnRefreshPort_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(37, 225);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "发送角度数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbServoAngle
            // 
            this.gbServoAngle.Controls.Add(this.lbServoAngle6);
            this.gbServoAngle.Controls.Add(this.btnSend);
            this.gbServoAngle.Controls.Add(this.lbServoAngle5);
            this.gbServoAngle.Controls.Add(this.lbServoAngle4);
            this.gbServoAngle.Controls.Add(this.lbServoAngle3);
            this.gbServoAngle.Controls.Add(this.lbServoAngle2);
            this.gbServoAngle.Controls.Add(this.lbServoAngle1);
            this.gbServoAngle.Controls.Add(this.hsbServo2);
            this.gbServoAngle.Controls.Add(this.hsbServo3);
            this.gbServoAngle.Controls.Add(this.hsbServo4);
            this.gbServoAngle.Controls.Add(this.hsbServo5);
            this.gbServoAngle.Controls.Add(this.hsbServo6);
            this.gbServoAngle.Controls.Add(this.hsbServo1);
            this.gbServoAngle.Controls.Add(this.label11);
            this.gbServoAngle.Controls.Add(this.label10);
            this.gbServoAngle.Controls.Add(this.label9);
            this.gbServoAngle.Controls.Add(this.label8);
            this.gbServoAngle.Controls.Add(this.label7);
            this.gbServoAngle.Controls.Add(this.label6);
            this.gbServoAngle.Location = new System.Drawing.Point(300, 12);
            this.gbServoAngle.Name = "gbServoAngle";
            this.gbServoAngle.Size = new System.Drawing.Size(340, 263);
            this.gbServoAngle.TabIndex = 17;
            this.gbServoAngle.TabStop = false;
            this.gbServoAngle.Text = "发送角度设置";
            // 
            // lbServoAngle6
            // 
            this.lbServoAngle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbServoAngle6.Location = new System.Drawing.Point(246, 194);
            this.lbServoAngle6.Name = "lbServoAngle6";
            this.lbServoAngle6.Size = new System.Drawing.Size(40, 12);
            this.lbServoAngle6.TabIndex = 25;
            // 
            // lbServoAngle5
            // 
            this.lbServoAngle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbServoAngle5.Location = new System.Drawing.Point(246, 163);
            this.lbServoAngle5.Name = "lbServoAngle5";
            this.lbServoAngle5.Size = new System.Drawing.Size(40, 12);
            this.lbServoAngle5.TabIndex = 25;
            // 
            // lbServoAngle4
            // 
            this.lbServoAngle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbServoAngle4.Location = new System.Drawing.Point(246, 130);
            this.lbServoAngle4.Name = "lbServoAngle4";
            this.lbServoAngle4.Size = new System.Drawing.Size(40, 12);
            this.lbServoAngle4.TabIndex = 25;
            // 
            // lbServoAngle3
            // 
            this.lbServoAngle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbServoAngle3.Location = new System.Drawing.Point(246, 101);
            this.lbServoAngle3.Name = "lbServoAngle3";
            this.lbServoAngle3.Size = new System.Drawing.Size(40, 12);
            this.lbServoAngle3.TabIndex = 25;
            // 
            // lbServoAngle2
            // 
            this.lbServoAngle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbServoAngle2.Location = new System.Drawing.Point(246, 75);
            this.lbServoAngle2.Name = "lbServoAngle2";
            this.lbServoAngle2.Size = new System.Drawing.Size(40, 12);
            this.lbServoAngle2.TabIndex = 25;
            // 
            // lbServoAngle1
            // 
            this.lbServoAngle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbServoAngle1.Location = new System.Drawing.Point(246, 49);
            this.lbServoAngle1.Name = "lbServoAngle1";
            this.lbServoAngle1.Size = new System.Drawing.Size(40, 12);
            this.lbServoAngle1.TabIndex = 25;
            // 
            // hsbServo2
            // 
            this.hsbServo2.Location = new System.Drawing.Point(76, 67);
            this.hsbServo2.Maximum = 189;
            this.hsbServo2.Name = "hsbServo2";
            this.hsbServo2.Size = new System.Drawing.Size(153, 17);
            this.hsbServo2.TabIndex = 24;
            this.hsbServo2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbServo2_Scroll);
            // 
            // hsbServo3
            // 
            this.hsbServo3.Location = new System.Drawing.Point(76, 96);
            this.hsbServo3.Maximum = 189;
            this.hsbServo3.Name = "hsbServo3";
            this.hsbServo3.Size = new System.Drawing.Size(153, 17);
            this.hsbServo3.TabIndex = 23;
            this.hsbServo3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbServo3_Scroll);
            // 
            // hsbServo4
            // 
            this.hsbServo4.Location = new System.Drawing.Point(76, 125);
            this.hsbServo4.Maximum = 189;
            this.hsbServo4.Name = "hsbServo4";
            this.hsbServo4.Size = new System.Drawing.Size(153, 17);
            this.hsbServo4.TabIndex = 22;
            this.hsbServo4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbServo4_Scroll);
            // 
            // hsbServo5
            // 
            this.hsbServo5.Location = new System.Drawing.Point(76, 158);
            this.hsbServo5.Maximum = 189;
            this.hsbServo5.Name = "hsbServo5";
            this.hsbServo5.Size = new System.Drawing.Size(153, 17);
            this.hsbServo5.TabIndex = 21;
            this.hsbServo5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbServo5_Scroll);
            // 
            // hsbServo6
            // 
            this.hsbServo6.Location = new System.Drawing.Point(76, 189);
            this.hsbServo6.Maximum = 189;
            this.hsbServo6.Name = "hsbServo6";
            this.hsbServo6.Size = new System.Drawing.Size(153, 17);
            this.hsbServo6.TabIndex = 20;
            this.hsbServo6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbServo6_Scroll);
            // 
            // hsbServo1
            // 
            this.hsbServo1.Location = new System.Drawing.Point(76, 39);
            this.hsbServo1.Maximum = 189;
            this.hsbServo1.Name = "hsbServo1";
            this.hsbServo1.Size = new System.Drawing.Size(153, 17);
            this.hsbServo1.TabIndex = 19;
            this.hsbServo1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbServo1_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "#6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "#5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "#4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "#3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "#2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "#1";
            // 
            // tbRecv
            // 
            this.tbRecv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbRecv.Location = new System.Drawing.Point(12, 201);
            this.tbRecv.Multiline = true;
            this.tbRecv.Name = "tbRecv";
            this.tbRecv.ReadOnly = true;
            this.tbRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRecv.Size = new System.Drawing.Size(268, 165);
            this.tbRecv.TabIndex = 18;
            // 
            // gbComSetting
            // 
            this.gbComSetting.Controls.Add(this.CCbPortNo);
            this.gbComSetting.Controls.Add(this.CCbCheckBit);
            this.gbComSetting.Controls.Add(this.CCbStopBits);
            this.gbComSetting.Controls.Add(this.CBtnRefreshPort);
            this.gbComSetting.Controls.Add(this.CCbDataBits);
            this.gbComSetting.Controls.Add(this.label5);
            this.gbComSetting.Controls.Add(this.CCbBaudrate);
            this.gbComSetting.Controls.Add(this.label4);
            this.gbComSetting.Controls.Add(this.btnOpenOrClose);
            this.gbComSetting.Controls.Add(this.label3);
            this.gbComSetting.Controls.Add(this.label1);
            this.gbComSetting.Controls.Add(this.label2);
            this.gbComSetting.Location = new System.Drawing.Point(12, 12);
            this.gbComSetting.Name = "gbComSetting";
            this.gbComSetting.Size = new System.Drawing.Size(268, 165);
            this.gbComSetting.TabIndex = 19;
            this.gbComSetting.TabStop = false;
            this.gbComSetting.Text = "串口设置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "接收区";
            // 
            // btnClearRecv
            // 
            this.btnClearRecv.Location = new System.Drawing.Point(14, 372);
            this.btnClearRecv.Name = "btnClearRecv";
            this.btnClearRecv.Size = new System.Drawing.Size(75, 23);
            this.btnClearRecv.TabIndex = 20;
            this.btnClearRecv.Text = "清空接收区";
            this.btnClearRecv.UseVisualStyleBackColor = true;
            this.btnClearRecv.Click += new System.EventHandler(this.btnClearRecv_Click);
            // 
            // cbDispMode
            // 
            this.cbDispMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDispMode.FormattingEnabled = true;
            this.cbDispMode.Items.AddRange(new object[] {
            "10进制显示",
            "16进制显示",
            "字符串显示"});
            this.cbDispMode.Location = new System.Drawing.Point(109, 373);
            this.cbDispMode.Name = "cbDispMode";
            this.cbDispMode.Size = new System.Drawing.Size(95, 20);
            this.cbDispMode.TabIndex = 21;
            this.cbDispMode.SelectedIndexChanged += new System.EventHandler(this.cbDispMode_SelectedIndexChanged);
            // 
            // timerDisp
            // 
            this.timerDisp.Enabled = true;
            this.timerDisp.Tick += new System.EventHandler(this.timerDisp_Tick);
            // 
            // ServoCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 403);
            this.Controls.Add(this.cbDispMode);
            this.Controls.Add(this.btnClearRecv);
            this.Controls.Add(this.gbComSetting);
            this.Controls.Add(this.tbRecv);
            this.Controls.Add(this.gbServoAngle);
            this.Controls.Add(this.label12);
            this.Name = "ServoCtrl";
            this.Text = "ServoCtrl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbServoAngle.ResumeLayout(false);
            this.gbServoAngle.PerformLayout();
            this.gbComSetting.ResumeLayout(false);
            this.gbComSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort CserialPort;
        private System.Windows.Forms.Button btnOpenOrClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CCbPortNo;
        private System.Windows.Forms.ComboBox CCbCheckBit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CCbStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CCbDataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CCbBaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CBtnRefreshPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbServoAngle;
        private System.Windows.Forms.HScrollBar hsbServo2;
        private System.Windows.Forms.HScrollBar hsbServo3;
        private System.Windows.Forms.HScrollBar hsbServo4;
        private System.Windows.Forms.HScrollBar hsbServo5;
        private System.Windows.Forms.HScrollBar hsbServo6;
        private System.Windows.Forms.HScrollBar hsbServo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbServoAngle6;
        private System.Windows.Forms.Label lbServoAngle5;
        private System.Windows.Forms.Label lbServoAngle4;
        private System.Windows.Forms.Label lbServoAngle3;
        private System.Windows.Forms.Label lbServoAngle2;
        private System.Windows.Forms.Label lbServoAngle1;
        private System.Windows.Forms.TextBox tbRecv;
        private System.Windows.Forms.GroupBox gbComSetting;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClearRecv;
        private System.Windows.Forms.ComboBox cbDispMode;
        private System.Windows.Forms.Timer timerDisp;
    }
}

