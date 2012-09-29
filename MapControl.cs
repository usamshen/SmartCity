using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace SmartCity
{

    

    public partial class MapControl : DevExpress.XtraEditors.XtraForm
    {

        private int eventCount = 0;
        private int ondrag = 0;

        private Point screenOffset;
        private DateTime eventTime;
        //private rfid rfid1 = new rfid();

        private int scrollx = 0;
        private int scrolly = 0;

        private Control.ControlCollection cctags;


        public MapControl()
        {
            InitializeComponent();
             (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
             (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

             (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);

           // (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            (new SmartCity.DatasetSmartCityTableAdapters.LightTableAdapter()).FillByArea(smartCity1.Light, comboBox1.Text);
            
           
        }

        private void MasterDataMap_Load(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
               string map = smartCity1.Area.Select("AreaName='" + comboBox1.Text + "'")[0]["map"].ToString();

                Image im = Image.FromFile(@"photo/" + map); // System.Drawing.Color.Lime;
               pictureBox1.Width= im.Width;
               pictureBox1.Height = im.Height;
                pictureBox1.Image = im;
            }
            (new SmartCity.DatasetSmartCityTableAdapters.LightTableAdapter()).FillByArea(smartCity1.Light, comboBox1.Text);
         
            LoadLights();
         
        }


        private void LoadLights()
        {
            ArrayList al = new ArrayList();



            foreach (Control item in panel1.Controls)
            {
                if (item.ToString() == "SmartCity.UCLight")
                {
                    al.Add(item);
                }

            }

            foreach (Control item in al)
            {
                panel1.Controls.Remove(item);

            }

            foreach (SmartCity.DatasetSmartCity.LightRow light in smartCity1.Light)
            {
                if ((light.x == 0 & light.y == 0) || (light.x == null & light.y == null))
                {
                    continue;
                }
                Image im = Properties.Resources.light; // System.Drawing.Color.Lime;


                UCLight mylight = new UCLight(im, smartCity1.Controller.Select("controllerName='" + light.controller + "'")[0]["SIM"].ToString(), "SETPW-" + light.LightName + "X250");

                //  PictureBox mytag = new PictureBox();
                //   mytag.Image = im;

                mylight.AutoSize = true;
                mylight.Tag = "LIGHT";

                mylight.Location = new System.Drawing.Point(light.x, light.y);
                //  mytag.Name = name.Split(',')[0].ToString();
                mylight.Size = new System.Drawing.Size(40, 60);

     
                mylight.BackColor = Color.White;

                mylight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);


               
                this.panel1.Controls.Add(mylight);
                mylight.BringToFront();
        
                
            }
            this.panel1.PerformLayout();
            this.ResumeLayout(true);
        }

        private void MasterDataMap_DragOver(object sender, DragEventArgs e)
        {
            Size dragSize = SystemInformation.DragSize;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        

        private void panel1_DragDrop(object sender, DragEventArgs e)
        { 
        }


        private void label1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
          

        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

            


        }

        private void gridView6_MouseDown(object sender, MouseEventArgs e)
        {
   
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            (new SmartCity.DatasetSmartCityTableAdapters.LightTableAdapter()).FillByArea(smartCity1.Light,comboBox1.Text);
           
            string   map = smartCity1.Area.Select("AreaName='" + comboBox1.Text + "'")[0]["map"].ToString();
            
            if (map != "")
             {
                 Image im = Image.FromFile(@"photo/" + map); // System.Drawing.Color.Lime;

                 pictureBox1.Image = im;
                 LoadLights();
             }
             else
             {
                 pictureBox1.Image = null;
             }
            
        }

        private void panel1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new SmartCity.DatasetSmartCityTableAdapters.LightTableAdapter()).Update(smartCity1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl6_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}