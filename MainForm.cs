using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SmartCity
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public static System.IO.Ports.SerialPort serialPort1= new System.IO.Ports.SerialPort();

        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MapControl abc = new MapControl();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XtraForm1 abc = new XtraForm1();
            //abc.TopLevel = false;

            //abc.MdiParent = this;
            //abc.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(@"photo"))
            {
                System.IO.Directory.CreateDirectory(@"photo");
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterDataProduct abc = new MasterDataProduct(); 
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterDataArea abc = new MasterDataArea();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterDataController abc = new MasterDataController();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterDataLight abc = new  MasterDataLight();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterDataMap abc = new  MasterDataMap();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            MasterDataProductType abc = new MasterDataProductType();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConfigSerial abc = new ConfigSerial();
            abc.TopLevel = false;

            abc.MdiParent = this;
            abc.Show();
        }
    }
}