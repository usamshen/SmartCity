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

    

    public partial class MasterDataMap : DevExpress.XtraEditors.XtraForm
    {

        private int eventCount = 0;
        private int ondrag = 0;

        private Point screenOffset;
        private DateTime eventTime;
        //private rfid rfid1 = new rfid();

        private int scrollx = 0;
        private int scrolly = 0;

        private Control.ControlCollection cctags;

       
        public MasterDataMap()
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
            LoadLights();
         
        }


        private void LoadLights()
        {
            foreach (SmartCity.DatasetSmartCity.LightRow light in smartCity1.Light)
            {

                Image im = Image.FromFile(@"photo/light.jpg"); // System.Drawing.Color.Lime;


                UCLight mylight = new UCLight(im, light.LightName);

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
            //   int x = readerx;
            //  int y = readery;
            try
            {
                SmartCity.DatasetSmartCity.LightRow light = (SmartCity.DatasetSmartCity.LightRow)gridView6.GetFocusedDataRow();
              
        

                foreach (Control item in panel1.Controls)
                {
                    if (item.ToString()=="SmartCity.UCLight")
                    {
                         if (((UCLight)item).labelname == light.LightName)
                        {
                         //   MessageBox.Show("This Antenna is already in the map.");
                            return;

                        }

                    }

                }

                label2.Text=e.X.ToString() + " " + e.Y.ToString();

                int overallx = PointToClient(Cursor.Position).X;
                int overally = PointToClient(Cursor.Position).Y;
                int x = overallx - this.panel1.Location.X;// - this.panel1.Width;// +scrollx;
                int y = overally - this.panel1.Location.Y;// +scrolly;


                this.panel1.SuspendLayout();
                this.SuspendLayout();
                // add the selected string to bottom of list

                Image im = Image.FromFile(@"photo/light.jpg"); // System.Drawing.Color.Lime;

               
                UCLight mylight = new UCLight(im,light.LightName);

                //  PictureBox mytag = new PictureBox();
                //   mytag.Image = im;

                mylight.AutoSize = true;
                mylight.Tag = "LIGHT";

                mylight.Location = new System.Drawing.Point(x, y);
                //  mytag.Name = name.Split(',')[0].ToString();
                mylight.Size = new System.Drawing.Size(40, 60);

                ((SmartCity.DatasetSmartCity.LightRow)gridView6.GetFocusedDataRow()).x = x + scrollx;
                ((SmartCity.DatasetSmartCity.LightRow)gridView6.GetFocusedDataRow()).y = y + scrolly;


                mylight.BackColor = Color.White;

                mylight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);


                foreach (Control item in panel1.Controls)
                {
                    if (item.ToString() == "UCLight")
                    {
                        if (((UCLight)item).labelname == light.LightName)
                        {
                          //  MessageBox.Show("This Antenna is already in the map.");
                            return;

                        }

                    }

                }
                    this.panel1.Controls.Add(mylight);
                    mylight.BringToFront();
                    this.panel1.PerformLayout();
                    this.ResumeLayout(true);
                   // button5.Select();

                    panel1.AllowDrop = false;

                 //   gridView6.SelectRow(0);
                    button5_Click(null, null);

                    //panel1.AllowDrop = true;

                // textBox1.SelectAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void label1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                // Cancel the drag if the mouse moves off the form. The screenOffset
                // takes into account any desktop bands that may be at the top or left
                // side of the screen.
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                    ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                    ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                    ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }

            eventCount = eventCount + 1;  // increment event counter

        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                //  MessageBox.Show(e.Location.ToString());
           //     int x = PointToClient(Cursor.Position).X - this.panel1.Location.X - this.panel1.Width;// +scrollx;
             //   int y = PointToClient(Cursor.Position).Y - this.panel1.Location.Y;// +scrolly;
                int overallx = PointToClient(Cursor.Position).X;
                int overally = PointToClient(Cursor.Position).Y;
                int x = overallx - this.panel1.Location.X;// - this.panel1.Width;// +scrollx;
                int y = overally - this.panel1.Location.Y;// +scrolly;

                //    int x = readerx;
                //    int y = readery;

                //            int x =   this.panel1.Location.X;
                //      int y =   this.panel1.Location.Y;

                this.panel1.SuspendLayout();
                this.SuspendLayout();

                ((UCLight)sender).Location = new Point(x, y);
                // ((PictureBox)sender).Location = new Point(x, y);

                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                this.ResumeLayout(false);

                string name = ((UCLight)sender).labelname;
               

                foreach (SmartCity.DatasetSmartCity.LightRow item in smartCity1.Light.Rows)
                {
                    if (item.LightName.ToString() == name )
                    {
                        item.x = x + scrollx;
                        item.y = y + scrolly;

                       
                        break;

                    }
                }

             //   SaveData();

            }


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
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                // Cancel the drag if the mouse moves off the form. The screenOffset
                // takes into account any desktop bands that may be at the top or left
                // side of the screen.
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                    ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                    ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                    ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }

            eventCount = eventCount + 1;  // increment event counter
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
            eventCount = eventCount + 1;  // increment event counter

         //   MessageBox.Show(e.Location.ToString()+ gridControl6.Width);
            if (e.Location.X > 0
               & e.Location.X < gridControl6.Width
               & e.Location.Y > 0
               & e.Location.Y < gridControl6.Height)
            {

                gridControl6.DoDragDrop("Reader", DragDropEffects.Copy);
                panel1.AllowDrop = true;

            }
        }
    }
}