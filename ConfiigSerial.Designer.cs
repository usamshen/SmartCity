namespace SmartCity
{
    partial class ConfigSerial
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {  
            serialPort1.Dispose();
            serialPort1.Close();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
          
            
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_SPNumber = new System.Windows.Forms.ComboBox();
            this.cb_SPBaudRate = new System.Windows.Forms.ComboBox();
            this.cb_SPDataBits = new System.Windows.Forms.ComboBox();
            this.cb_SPStopBits = new System.Windows.Forms.ComboBox();
            this.cb_SPParity = new System.Windows.Forms.ComboBox();
            this.cb_SPHandshake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tB_Send = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Take = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_PhNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_SPNumber
            // 
            this.cb_SPNumber.FormattingEnabled = true;
            this.cb_SPNumber.Location = new System.Drawing.Point(67, 23);
            this.cb_SPNumber.Name = "cb_SPNumber";
            this.cb_SPNumber.Size = new System.Drawing.Size(79, 21);
            this.cb_SPNumber.Sorted = true;
            this.cb_SPNumber.TabIndex = 3;
            // 
            // cb_SPBaudRate
            // 
            this.cb_SPBaudRate.FormattingEnabled = true;
            this.cb_SPBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400"});
            this.cb_SPBaudRate.Location = new System.Drawing.Point(238, 23);
            this.cb_SPBaudRate.Name = "cb_SPBaudRate";
            this.cb_SPBaudRate.Size = new System.Drawing.Size(79, 21);
            this.cb_SPBaudRate.TabIndex = 4;
            // 
            // cb_SPDataBits
            // 
            this.cb_SPDataBits.FormattingEnabled = true;
            this.cb_SPDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cb_SPDataBits.Location = new System.Drawing.Point(67, 51);
            this.cb_SPDataBits.Name = "cb_SPDataBits";
            this.cb_SPDataBits.Size = new System.Drawing.Size(79, 21);
            this.cb_SPDataBits.TabIndex = 5;
            // 
            // cb_SPStopBits
            // 
            this.cb_SPStopBits.FormattingEnabled = true;
            this.cb_SPStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cb_SPStopBits.Location = new System.Drawing.Point(238, 51);
            this.cb_SPStopBits.Name = "cb_SPStopBits";
            this.cb_SPStopBits.Size = new System.Drawing.Size(79, 21);
            this.cb_SPStopBits.TabIndex = 6;
            // 
            // cb_SPParity
            // 
            this.cb_SPParity.FormattingEnabled = true;
            this.cb_SPParity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.cb_SPParity.Location = new System.Drawing.Point(67, 79);
            this.cb_SPParity.Name = "cb_SPParity";
            this.cb_SPParity.Size = new System.Drawing.Size(79, 21);
            this.cb_SPParity.TabIndex = 15;
            // 
            // cb_SPHandshake
            // 
            this.cb_SPHandshake.FormattingEnabled = true;
            this.cb_SPHandshake.Items.AddRange(new object[] {
            "HARDWARE",
            "SOFTWARE",
            "NONE",
            "CUSTOM"});
            this.cb_SPHandshake.Location = new System.Drawing.Point(238, 79);
            this.cb_SPHandshake.Name = "cb_SPHandshake";
            this.cb_SPHandshake.Size = new System.Drawing.Size(79, 21);
            this.cb_SPHandshake.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "串口号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "停止位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "校验位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "流控制";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_Send
            // 
            this.tB_Send.Location = new System.Drawing.Point(57, 193);
            this.tB_Send.Name = "tB_Send";
            this.tB_Send.Size = new System.Drawing.Size(219, 20);
            this.tB_Send.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "发送内容";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "接收内容";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // tB_Take
            // 
            this.tB_Take.Location = new System.Drawing.Point(57, 229);
            this.tB_Take.Name = "tB_Take";
            this.tB_Take.Size = new System.Drawing.Size(219, 20);
            this.tB_Take.TabIndex = 17;
            this.tB_Take.TextChanged += new System.EventHandler(this.tB_Take_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "接收号码";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tB_PhNumber
            // 
            this.tB_PhNumber.Location = new System.Drawing.Point(57, 156);
            this.tB_PhNumber.Name = "tB_PhNumber";
            this.tB_PhNumber.Size = new System.Drawing.Size(219, 20);
            this.tB_PhNumber.TabIndex = 0;
            // 
            // SerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 268);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tB_PhNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tB_Take);
            this.Controls.Add(this.tB_Send);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_SPHandshake);
            this.Controls.Add(this.cb_SPParity);
            this.Controls.Add(this.cb_SPStopBits);
            this.Controls.Add(this.cb_SPDataBits);
            this.Controls.Add(this.cb_SPBaudRate);
            this.Controls.Add(this.cb_SPNumber);
            this.Name = "SerialPort";
            this.Text = "SerialPort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_SPNumber;
        private System.Windows.Forms.ComboBox cb_SPBaudRate;
        private System.Windows.Forms.ComboBox cb_SPDataBits;
        private System.Windows.Forms.ComboBox cb_SPStopBits;
        private System.Windows.Forms.ComboBox cb_SPParity;
        private System.Windows.Forms.ComboBox cb_SPHandshake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB_Send;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Take;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_PhNumber;
    }
}

