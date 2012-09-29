using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SmartCity
{
    public partial class ConfigSerial : DevExpress.XtraEditors.XtraForm
    {
        public ConfigSerial()
        {
            try
            {
                InitializeComponent();
                ScanSerialPortNumber();//扫描所有串口并列表
                SP_Setup();//设置当前串口参数
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
       
            //serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e);
        }

        public ConfigSerial(string phoneno, string msg)
        {
            InitializeComponent();
            ScanSerialPortNumber();//扫描所有串口并列表
            SP_Setup();//设置当前串口参数

            tB_PhNumber.Text = phoneno;
            tB_Send.Text = msg;

            //serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e);
        }

        private void ScanSerialPortNumber()
        {
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i <= portNames.LongLength - 1; i++)
            {
                cb_SPNumber.Items.Add(portNames[i]);
            }
            cb_SPNumber.SelectedIndex = 0;//默认将显示COM1
            cb_SPBaudRate.SelectedIndex = 6;//默认显示波特率为9600
            cb_SPDataBits.SelectedIndex = 0;//默认显示数据位为8
            cb_SPStopBits.SelectedIndex = 0;//默认显示停止位为1
            cb_SPParity.SelectedIndex = 0;//默认显示校验位为NONE
            cb_SPHandshake.SelectedIndex = 2;//默认显示流控制为NONE
        }

        private void SP_Setup()
        {
            serialPort1.Close();
            serialPort1.PortName = cb_SPNumber.SelectedItem.ToString();  //设置串口号
            serialPort1.BaudRate = Convert.ToInt16(cb_SPBaudRate.SelectedItem.ToString());//设置波特率
            serialPort1.DataBits = Convert.ToInt16(cb_SPDataBits.SelectedItem.ToString());//设置数据位
            switch (cb_SPStopBits.SelectedItem.ToString())//设置停止位
            {
                case "1":
                    serialPort1.StopBits = StopBits.One;
                    break;
                case "1.5":
                    serialPort1.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort1.StopBits = StopBits.Two;
                    break;
            }
            switch (cb_SPHandshake.SelectedItem.ToString())//设置流控制
            {
                case "HARDWARE":
                    serialPort1.Handshake = Handshake.RequestToSend;
                    break;
                case "SOFTWARE":
                    serialPort1.Handshake = Handshake.XOnXOff;
                    break;
                case "NONE":
                    serialPort1.Handshake = Handshake.None;
                    break;
                case "Custom":
                    serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
                    break;
            }
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show(cb_SPNumber.SelectedItem.ToString() + "已经被占用，请重新选择端口", "警告");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveConfig()
        {
            ComConfig ds =new ComConfig();
            ds.ReadXml("ComConfig.xsd");

            if (ds.config.Rows.Count==0)
            {
              //  rConfig
                
            }
            serialPort1.PortName = cb_SPNumber.SelectedItem.ToString();  //设置串口号
            serialPort1.BaudRate = Convert.ToInt16(cb_SPBaudRate.SelectedItem.ToString());//设置波特率
            serialPort1.DataBits = Convert.ToInt16(cb_SPDataBits.SelectedItem.ToString());//设置数据位
            switch (cb_SPStopBits.SelectedItem.ToString())//设置停止位
            {
                case "1":
                    serialPort1.StopBits = StopBits.One;
                    break;
                case "1.5":
                    serialPort1.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort1.StopBits = StopBits.Two;
                    break;
            }
            switch (cb_SPHandshake.SelectedItem.ToString())//设置流控制
            {
                case "HARDWARE":
                    serialPort1.Handshake = Handshake.RequestToSend;
                    break;
                case "SOFTWARE":
                    serialPort1.Handshake = Handshake.XOnXOff;
                    break;
                case "NONE":
                    serialPort1.Handshake = Handshake.None;
                    break;
                case "Custom":
                    serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SP_Setup();
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("设置成功，当前端口为" + cb_SPNumber.SelectedItem.ToString(), "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("AT+CMGF=1\r");//开启文本短信
                Delay(100);//100ms延时。目的是等待GPRS模块响应
                serialPort1.WriteLine("AT+CMGS=" + "\"" + tB_PhNumber.Text + "\"\r");//输入手机号
                Delay(100);
                serialPort1.WriteLine(tB_Send.Text + "\r");//发送文本内容
                Delay(100);
                serialPort1.WriteLine("\x1A");//发送Ctrl-Z完成发送
                Delay(100);
                serialPort1.DiscardOutBuffer();//清串口输出缓存
                MessageBox.Show("数据发送完毕！", "系统提示");
                serialPort1.Close();
            }
            catch
            {
                MessageBox.Show("端口设置异常，请重新设置端口", "警告");
            }
        }

        private void tB_Take_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    tB_Take.Text = serialPort1.ReadLine();
        //    serialPort1.DiscardInBuffer();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("\x1A");
            //serialPort1.DiscardOutBuffer();
            //tB_Take.Text=DataReceived
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //延时
        private void Delay(int mm)
        {
            DateTime current = DateTime.Now;

            while (current.AddMilliseconds(mm) > DateTime.Now)
            {
                Application.DoEvents();
            }
            return;
        }


        //将接收的数据显示到tB_Take中。
        //void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    MessageBox.Show("ok");
        //    string serialReadString;
        //    serialReadString = serialPort1.ReadExisting();
        //    this.tB_Take.Invoke(new MethodInvoker(delegate
        //    {
        //        this.tB_Take.AppendText(serialReadString);
        //    }
        //            )
        //        );
        //}

    }
}