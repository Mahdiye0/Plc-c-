namespace Wintestplc2
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
            this.btnRtu = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btndis = new System.Windows.Forms.Button();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.cmbBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBits = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTcp = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbWrite = new System.Windows.Forms.RadioButton();
            this.rdbRead = new System.Windows.Forms.RadioButton();
            this.txtregister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.rdbHex = new System.Windows.Forms.RadioButton();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnforce = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRtu
            // 
            this.btnRtu.Location = new System.Drawing.Point(10, 241);
            this.btnRtu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRtu.Name = "btnRtu";
            this.btnRtu.Size = new System.Drawing.Size(86, 25);
            this.btnRtu.TabIndex = 0;
            this.btnRtu.Text = "Connect#2";
            this.btnRtu.UseVisualStyleBackColor = true;
            this.btnRtu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(275, 25);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStart.Name = "txtStart";
            this.txtStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStart.Size = new System.Drawing.Size(89, 22);
            this.txtStart.TabIndex = 24;
            this.txtStart.Text = "0";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "StartAddress:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btndis);
            this.groupBox3.Controls.Add(this.cmbPorts);
            this.groupBox3.Controls.Add(this.cmbBits);
            this.groupBox3.Controls.Add(this.cmbParity);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDevice);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtRate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnRtu);
            this.groupBox3.Controls.Add(this.txtBits);
            this.groupBox3.Location = new System.Drawing.Point(100, 148);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(271, 282);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // btndis
            // 
            this.btndis.Enabled = false;
            this.btndis.Location = new System.Drawing.Point(100, 241);
            this.btndis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndis.Name = "btndis";
            this.btndis.Size = new System.Drawing.Size(86, 25);
            this.btndis.TabIndex = 19;
            this.btndis.Text = "disConnect";
            this.btndis.UseVisualStyleBackColor = true;
            this.btndis.Click += new System.EventHandler(this.btndis_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(80, 54);
            this.cmbPorts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(167, 22);
            this.cmbPorts.TabIndex = 17;
            // 
            // cmbBits
            // 
            this.cmbBits.FormattingEnabled = true;
            this.cmbBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cmbBits.Location = new System.Drawing.Point(80, 203);
            this.cmbBits.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbBits.Name = "cmbBits";
            this.cmbBits.Size = new System.Drawing.Size(167, 22);
            this.cmbBits.TabIndex = 16;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cmbParity.Location = new System.Drawing.Point(80, 165);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(167, 22);
            this.cmbParity.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 14;
            this.label11.Text = ":stopBits ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = ":Parity";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(111, 24);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(89, 22);
            this.txtDevice.TabIndex = 18;
            this.txtDevice.Text = "1";
            this.txtDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = ":DeviceAddress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = ":Serial Port";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(80, 87);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(167, 22);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "9600";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = ":baudRate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = ":dataBits ";
            // 
            // txtBits
            // 
            this.txtBits.Location = new System.Drawing.Point(80, 126);
            this.txtBits.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBits.Name = "txtBits";
            this.txtBits.Size = new System.Drawing.Size(167, 22);
            this.txtBits.TabIndex = 7;
            this.txtBits.Text = "7";
            this.txtBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 173);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2.Size = new System.Drawing.Size(81, 18);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Serial /Rtu";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(60, 18);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.Text = "Tcp/ip";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTcp);
            this.groupBox2.Controls.Add(this.txtIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Location = new System.Drawing.Point(100, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(271, 121);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnTcp
            // 
            this.btnTcp.Location = new System.Drawing.Point(49, 83);
            this.btnTcp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTcp.Name = "btnTcp";
            this.btnTcp.Size = new System.Drawing.Size(86, 25);
            this.btnTcp.TabIndex = 8;
            this.btnTcp.Text = "Connect#1";
            this.btnTcp.UseVisualStyleBackColor = true;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(80, 21);
            this.txtIp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(174, 22);
            this.txtIp.TabIndex = 6;
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = ":IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = ":Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(80, 49);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(174, 22);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "502";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pic
            // 
            this.pic.BackgroundImage = global::Wintestplc2.Properties.Resources.icons8_disconnected_30;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.Location = new System.Drawing.Point(721, 415);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(34, 27);
            this.pic.TabIndex = 29;
            this.pic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMulti);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.rdbHex);
            this.groupBox1.Controls.Add(this.rdbDecimal);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(385, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(375, 276);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read && Write Date From PLC";
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(280, 229);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(84, 25);
            this.btnMulti.TabIndex = 41;
            this.btnMulti.Text = "WriteMulti";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(281, 53);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 14);
            this.lbl.TabIndex = 33;
            this.lbl.Text = "Plc Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.txt2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.rdbWrite);
            this.groupBox4.Controls.Add(this.rdbRead);
            this.groupBox4.Controls.Add(this.txtregister);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt1);
            this.groupBox4.Location = new System.Drawing.Point(15, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(251, 219);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(180, 22);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(78, 167);
            this.txt2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt2.Name = "txt2";
            this.txt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt2.Size = new System.Drawing.Size(89, 22);
            this.txt2.TabIndex = 40;
            this.txt2.Text = "0";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 14);
            this.label12.TabIndex = 39;
            this.label12.Text = "Text2:";
            // 
            // rdbWrite
            // 
            this.rdbWrite.AutoSize = true;
            this.rdbWrite.Location = new System.Drawing.Point(12, 115);
            this.rdbWrite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbWrite.Name = "rdbWrite";
            this.rdbWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbWrite.Size = new System.Drawing.Size(55, 18);
            this.rdbWrite.TabIndex = 38;
            this.rdbWrite.Text = "Write";
            this.rdbWrite.UseVisualStyleBackColor = true;
            // 
            // rdbRead
            // 
            this.rdbRead.AutoSize = true;
            this.rdbRead.Location = new System.Drawing.Point(12, 21);
            this.rdbRead.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRead.Name = "rdbRead";
            this.rdbRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbRead.Size = new System.Drawing.Size(52, 18);
            this.rdbRead.TabIndex = 37;
            this.rdbRead.Text = "Read";
            this.rdbRead.UseVisualStyleBackColor = true;
            // 
            // txtregister
            // 
            this.txtregister.Location = new System.Drawing.Point(124, 41);
            this.txtregister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtregister.Name = "txtregister";
            this.txtregister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtregister.Size = new System.Drawing.Size(89, 22);
            this.txtregister.TabIndex = 35;
            this.txtregister.Text = "0";
            this.txtregister.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "NumRegister:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Text1:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(78, 140);
            this.txt1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt1.Name = "txt1";
            this.txt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt1.Size = new System.Drawing.Size(89, 22);
            this.txt1.TabIndex = 24;
            this.txt1.Text = "0";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdbHex
            // 
            this.rdbHex.AutoSize = true;
            this.rdbHex.Location = new System.Drawing.Point(27, 23);
            this.rdbHex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbHex.Name = "rdbHex";
            this.rdbHex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbHex.Size = new System.Drawing.Size(46, 18);
            this.rdbHex.TabIndex = 29;
            this.rdbHex.Text = "Hex";
            this.rdbHex.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Location = new System.Drawing.Point(107, 23);
            this.rdbDecimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbDecimal.Size = new System.Drawing.Size(66, 18);
            this.rdbDecimal.TabIndex = 30;
            this.rdbDecimal.Text = "Decimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(278, 198);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 25);
            this.btnStart.TabIndex = 31;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnforce
            // 
            this.btnforce.Location = new System.Drawing.Point(339, 427);
            this.btnforce.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnforce.Name = "btnforce";
            this.btnforce.Size = new System.Drawing.Size(86, 25);
            this.btnforce.TabIndex = 32;
            this.btnforce.Text = "ForceConnet";
            this.btnforce.UseVisualStyleBackColor = true;
            this.btnforce.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 454);
            this.Controls.Add(this.btnforce);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRtu;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.ComboBox cmbBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBits;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTcp;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDecimal;
        private System.Windows.Forms.RadioButton rdbHex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbWrite;
        private System.Windows.Forms.RadioButton rdbRead;
        private System.Windows.Forms.TextBox txtregister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndis;
        private System.Windows.Forms.Button btnforce;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnMulti;
    }
}

