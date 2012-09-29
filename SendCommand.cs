using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SmartCity
{
    public partial class SendCommand : DevExpress.XtraEditors.XtraForm
    {
        public SendCommand()
        {
            InitializeComponent();
        }

        public SendCommand(string lightname, string value )
        {
            InitializeComponent();

            
        }

        private void  Send()
        {
            
        }

        private void SendCommand_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPENALL");
            this.Close();
        }
    }
}