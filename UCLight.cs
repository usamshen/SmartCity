using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartCity
{
    public partial class UCLight : UserControl
    {
        public string labelname;
        public string _phoneno;
        public string _msg;

        public UCLight(Image pic, string phoneno, string msg)
        {
            InitializeComponent();
            this.BackgroundImage = pic;
            _phoneno = phoneno;
            _msg = msg;
         //   this.taglabel.Text = name;
         //   this.taglabel.ForeColor = Color.Red;
         //   labelname = name;
  //          MessageBox.Show(name);
    //        tagname = name;
            
        }
           public UCLight( )
        {
            InitializeComponent();
        }

        private void Usertag_Load(object sender, EventArgs e)
        {

        }

        private void taglabel_Click(object sender, EventArgs e)
        {

        }

        private void UCLight_MouseEnter(object sender, EventArgs e)
        {
           
             
        }

        private void UCLight_DoubleClick(object sender, EventArgs e)
        {
            (new ConfigSerial(_phoneno,_msg)).ShowDialog();
        }
    }
}
