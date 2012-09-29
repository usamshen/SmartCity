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
    public partial class UCTag : UserControl
    {
        public string tagname;

        public UCTag()
        {
            InitializeComponent();
        }

        public UCTag(string tagicon, string name)
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(@tagicon);
            this.taglabel.Text= name;

        }
    }
}
