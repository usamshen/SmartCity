using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThingMagic;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Impinj.OctaneSdk;
 
using System.Web;
using System.IO;
using System.Net;




namespace SmartCity
{


    public partial class MapOperation : Form
    {

        //当前读写器句柄，用于所有读写器操作的参数
        protected IntPtr _handle = IntPtr.Zero;
        /// <summary>
        /// 验证句柄的值是否有效
        /// </summary>
        private bool InvalidHandle
        {
            get
            {
                if (_handle == IntPtr.Zero || -1 == (int)_handle)
                {
                    return false;
                }
                return true;
            }
        }


        private int eventCount = 0;
        private int ondrag = 0;
 
        private Point screenOffset;
        private DateTime eventTime;
        private DatasetSmartCity rfid1 = new DatasetSmartCity();

        private int scrollx = 0;
        private int scrolly = 0;

        private Control.ControlCollection cctags;

        
        public MapOperation()
        {
          
       

            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
            pictureBox1.ImageLocation = @"photo/floor.png";

        }

     
          

      
        private void Form1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Size dragSize = SystemInformation.DragSize;

        }
 

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
         
            e.Effect = DragDropEffects.Copy;
            
        
        }

        private void UploadDataToServer()
        { 
        
        }

        private void UploadFiletoCloud()
        { 
        
        }

        
        //private void panel1_DragDrop(object sender, DragEventArgs e)
        //{
        // //   int x = readerx;
        //  //  int y = readery;
        //    try
        //    {
        //        DSSmartCity.Antenna_Row tagrow = (DSSmartCity.Antenna_Row)gridView3.GetFocusedDataRow();
        //        DSSmartCity.ReaderListRow readerrow = (DSSmartCity.ReaderListRow)gridView2.GetFocusedDataRow();

        //        foreach (Control item in panel1.Controls)
        //        {
        //            if (item.ToString()=="RfidTest.UCReader")
        //            {

        //                if (((UCReader)item).labelname== readerrow.name + ":"+tagrow.antennaid.ToString())
        //                {
        //                    MessageBox.Show("This Antenna is already in the map.");
        //                    return;
                            
        //                }
                        
        //            }
                    
        //        }

        //        int x = PointToClient(Cursor.Position).X - this.panel1.Location.X - this.splitContainer1.Panel1.Width;// +scrollx;
        //        int y = PointToClient(Cursor.Position).Y - this.panel1.Location.Y;// +scrolly;
           
             
        //        this.panel1.SuspendLayout();
        //        this.SuspendLayout();
        //        // add the selected string to bottom of list

        //        Image im = Image.FromFile(@"photo/light.jpg"); // System.Drawing.Color.Lime;

        //        string readername = rfid1.ReaderList.Select("server='" + tagrow.readerid + "'")[0][1].ToString();


        //        UCReader mytag = new UCReader(im, readername + ":" + tagrow.antennaid);

        //       //  PictureBox mytag = new PictureBox();
        //     //   mytag.Image = im;

        //        mytag.AutoSize = true;
        //        mytag.Tag = "Reader";

        //        mytag.Location = new System.Drawing.Point(x, y);
        //        //  mytag.Name = name.Split(',')[0].ToString();
        //        mytag.Size = new System.Drawing.Size(40, 60);

        //     //   ((DSSmartCity.Antenna_Row)gridView3.GetFocusedDataRow()).x = x+scrollx;
        //      //  ((DSSmartCity.Antenna_Row)gridView3.GetFocusedDataRow()).y = y+scrolly;


        //        mytag.BackColor = Color.White;
 
        //         mytag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);


        //         //if (rfid1.TagsPosition.Select("tagid='" + tagrow.readerid + "'").Length > 0)
        //         //{
        //         //    MessageBox.Show("The Tag is existing!");
        //         //}
        //         //else
        //         //{
        //         //    this.panel1.Controls.Add(mytag);
        //         //    mytag.BringToFront();
        //         //    this.panel1.PerformLayout();
        //         //    this.ResumeLayout(false);


        //         //    SaveData();
        //         //}

        //        // textBox1.SelectAll();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
 

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
                int x = PointToClient(Cursor.Position).X - this.panel1.Location.X - this.splitContainer1.Panel1.Width;// +scrollx;
                int y = PointToClient(Cursor.Position).Y - this.panel1.Location.Y;// +scrolly;
            //    int x = readerx;
            //    int y = readery;
                
                //            int x =   this.panel1.Location.X;
             //      int y =   this.panel1.Location.Y;

            this.panel1.SuspendLayout();
            this.SuspendLayout();

           ((UCReader)sender).Location = new Point(x, y);
            // ((PictureBox)sender).Location = new Point(x, y);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

           string name = ((UCReader)sender).labelname;
           string readername = name.Split(new char[]{':'})[0].ToString().Trim();
           string antID = name.Split(new char[] { ':' })[1].ToString().Trim();
           string readerid = rfid1.ReaderList.Select("name='" + readername + "'")[0][0].ToString();

            //foreach (DSSmartCity.Antenna_Row item in rfid1.Antenna_)
            //{
            //    if (item["readerid"].ToString() == readerid & item.antennaid.ToString() == antID.ToString()) 
            //    {
            //        item.x = x+scrollx;
            //        item.y = y+scrolly;

            //        rfid1.AcceptChanges();
            //        break;

            //    }
            //}

            SaveData();

            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        { 
          
           

        }

    

        private void button7_Click(object sender, EventArgs e)
        {
           

        }


        private Hashtable htjietags = new Hashtable();
        private Hashtable GetjieTagListByReader(string serverUri)
        {
            htjietags.Clear();
            byte idNum = 0;	// Max tag num is 200
            byte[] ids = new byte[12 * 200];	// The id length of each is 12, so 12 * 200 bytes is needed
            byte[] devNos = new byte[200];
            byte[] antennaNos = new byte[200];

            int i=0;
            do
            {
                i++;

              //  EPCSDKHelper.ResumeReading(_handle, 0);
                if (EPCSDKHelper.IdentifyUploadedMultiTags(_handle, out idNum, ids, devNos, antennaNos))
                {

                    String strTmp = "";
                    for (int j = 0; j < idNum; j++)
                    {
                       
                        byte[] bTmp = new byte[12];
                        Buffer.BlockCopy(ids, 12 * j, bTmp, 0, 12);
                        //if (this.rtbTag.Text.Contains(TextEncoder.ByteArrayToHexString(bTmp)) & this.checkBox1.Checked)
                        //    continue;
                        if (!htjietags.Contains(TextEncoder.ByteArrayToHexString(bTmp)))
                            htjietags.Add(TextEncoder.ByteArrayToHexString(bTmp), devNos[j]);
                        // strTmp += string.Format(no.ToString() + "  {0}    Device No:{1}  Antenna No: {2}  " + DateTime.Now.ToString() + "\r\n", TextEncoder.ByteArrayToHexString(bTmp), devNos[j], antennaNos[j]);
                    }


                }
            } while (i<2);
          

            

            return htjietags;
        }
     
        private Hashtable htimpinjtags = new Hashtable();
        private Hashtable GetThingImpinjTagListByReader(string serverUri)
        {
            SpeedwayReader impinjReader = new SpeedwayReader();
            htimpinjtags.Clear();
            // Connect to the reader.            
            // Replace "SpeedwayR-10-25-32" with your reader's hostname.            
            impinjReader.Connect(serverUri);
            // Assign an event handler for tag reports. This specifies            
            // which function will be called when tag reports arrive.            
            impinjReader.TagsReported += new EventHandler<TagsReportedEventArgs>(TagsReportedHandler);
            // Assign an event hadler for logging events.            
            impinjReader.Logging += new EventHandler<LoggingEventArgs>(LoggingHandler);
            // Clear all reader settings.            
            impinjReader.ClearSettings();
            // Get the factory settings for the reader. We will            
            // use these are a starting point and then modify            
            // the settings we're interested in.            
            Settings settings = impinjReader.QueryFactorySettings();
            // Send a report for every tag seen.            
            settings.Report.Mode = ReportMode.BatchAfterStop;
            // Include the antenna number in the tag report.            
            settings.Report.IncludeAntennaPortNumber = true;
            // Apply the new settings.            
            impinjReader.ApplySettings(settings);
            // Start reading tags.            
            impinjReader.Start();
            // Wait until the user presses return.            
            Console.WriteLine("Press enter when done.");
        //    System.Threading.Thread.Sleep(int.Parse(textBox1.Text));
          //  Console.ReadLine();
            // Clean up by clearing the settings and            
            // disconnecting from the reader.            
            impinjReader.ClearSettings();
            impinjReader.Disconnect();

            return htimpinjtags;
        }

        // The tag report event handler        
        private void TagsReportedHandler(object sender, TagsReportedEventArgs args)
        {
            // Loop through each tag in the report            
            // and print the EPC and antenna number.            
            foreach (Tag tag in args.TagReport.Tags)
            {
                if (!htimpinjtags.Contains(tag.Epc))
                {
                     htimpinjtags.Add(tag.Epc, tag.AntennaPortNumber);
               Console.WriteLine("Reader saw {0} on ant#{1}", tag.Epc, tag.AntennaPortNumber);
                 
                }
              
            }
        }
        private void LoggingHandler(object sender, LoggingEventArgs args)
        {
            // Write the log message to the console.            
            LogEntry entry = args.Entry;
            Console.WriteLine("Log level =  {0} {1}", entry.Level, entry.Message);

            
        } 

       

        private int GetNewIDofTags()
        {
            int max=0;
            foreach (DSSmartCity.TagListRow dr in rfid1.TagList.Rows)
            {
                if (int.Parse(dr[0].ToString() )> max)
                {
                    max = int.Parse(dr[0].ToString());
                }
            }
        
            return max+1;
        }

        
      
        private int GetRandomNo(){
        
            string a= ((new Random()).NextDouble() * 100).ToString();
            string s =  a.Substring(a.Length-2, 1);
            int i= int.Parse(s) %2;
            return i;
        }

        private void SaveData()
        {

            DSSmartCity myrfid = new DSSmartCity();

            myrfid = (DSSmartCity)rfid1.Copy();

            foreach (DSSmartCity.TagListRow item in myrfid.TagList.Rows)
            {
                item.icon = null;
            }

            myrfid.AcceptChanges();
            myrfid.WriteXml("data.xml");


            //*********************************
            //upload data to server....
            //*********************************
            
          
            

        
        }

        private void ReadData()
        {
            if( System.IO.File.Exists("data.xml"))
            {
                rfid1.ReadXml("data.xml");
                InitializeData();
    
            }
        }

        private void InitializeData()
        {
 
            foreach (DSSmartCity.Antenna_Row item in rfid1.Antenna_.Rows)
            {
                if (item.x.ToString()=="" || item.x.ToString()=="0")
                {
                    continue;
                    
                }
                string readername = rfid1.ReaderList.Select("server='" + item.readerid + "'")[0][1].ToString();
                
                Image im = Image.FromFile(@"photo/light.jpg");

                UCReader myAnt = new UCReader( im ,readername+":"+item.antennaid.ToString());
                myAnt.AutoSize = true;
                myAnt.BackColor = System.Drawing.Color.White;
                int x = int.Parse(item["x"].ToString());
                int y = int.Parse(item["y"].ToString());
                myAnt.Location = new System.Drawing.Point(x, y);
                myAnt.Tag = "Reader";
               

              //  mytag.Name = item["id"].ToString();
                myAnt.Size = new System.Drawing.Size(40, 60);
                myAnt.TabIndex = 3;
             //   mytag.Text = item["id"].ToString();
                myAnt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);

                this.panel1.Controls.Add(myAnt);
                myAnt.BringToFront();
        

            }

            foreach (DSSmartCity.TagListRow item in rfid1.TagList.Rows)
            {
                if (item.tagicon!="")
                {
                  // item.icon   = System.IO.File.ReadAllBytes(@"photo/"+item.tagicon);
   
                }
              
            }

        }

   

        // This event handler deals with the results of the
        // background operation.
        private void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {

               
              //  button7.Enabled = true;
            }
            //else
            //{
            //    // Finally, handle the case where the operation 
            //    // succeeded.
            //    resultLabel.Text = e.Result.ToString();
            //}

            //button1.Enabled = true;
    
            //// Enable the UpDown control.
            //this.numericUpDown1.Enabled = true;

            //// Enable the Start button.
            //startAsyncButton.Enabled = true;

            //// Disable the Cancel button.
            //cancelAsyncButton.Enabled = false;
        }
 

        // This is the method that does the actual work. For this
        // example, it computes a Fibonacci number and
        // reports progress as it does its work.
       

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            rfid1.TagList.Rows.Clear();
            ListBox ls = new ListBox();

            foreach (Control c in panel1.Controls)
            {
                if (c.Name != "pictureBox1")
                {
                    ls.Items.Add(c.Name);
                }

            }
            foreach (object c in ls.Items)  
            {

                panel1.Controls.RemoveByKey(c.ToString());
            }

            rfid1.TagsPosition.Rows.Clear();
            SaveData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox ls = new ListBox();

            foreach (Control c in panel1.Controls)
            {
                if (c.Name!="pictureBox1" ) 
                {
                    ls.Items.Add(c.Name);
                }
                
            }
            foreach (object c in ls.Items)
            {

                panel1.Controls.RemoveByKey(c.ToString());
            }

            rfid1.TagsPosition.Rows.Clear();
            SaveData();
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

       

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            string fileToSelect = "icon ";

            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {

                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();

                if (!fileToSelect.Contains(colCaption))
                {

                    return;
                }
                else
                {

                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "photo|*.jpg;*.png;*.gif";
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.FilterIndex = 1;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fName = openFileDialog.FileName;

                        System.IO.File.WriteAllBytes(@"photo/"+openFileDialog.SafeFileName, System.IO.File.ReadAllBytes(@fName));

                        view.SetFocusedValue(System.IO.File.ReadAllBytes(@fName));
                        gridView1.GetFocusedDataRow()[2] = openFileDialog.SafeFileName;//System.IO.File.ReadAllBytes(@fName);
                    }
                    else
                    {
                        view.SetFocusedValue(null);
                        gridView1.GetFocusedDataRow()[2] = null;
        

                    }
                }

            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;

            Point pt = view.GridControl.PointToClient(Control.MousePosition);

            DoRowDoubleClick(view, pt);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
            SaveData();
        
        }



        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
       
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
        
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (e.FocusedRowHandle < 0)
            //    return;
            //string s = gridView1.GetDataRow(e.FocusedRowHandle)[2].ToString();

            //if (s != "")
            //{
            //  //  pictureBox2.BackgroundImage = Image.FromFile(@s);
            //   // repositoryItemImageEdit1.i = Image.FromFile(@s);
            //}
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // starts a DoDragDrop operation with allowed effect  "Copy"
            eventCount = eventCount + 1;  // increment event counter
           


        }

      

        private void gridControl1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
          //  string server = ((rfid.ReaderListRow)gridView2.GetFocusedDataRow()).server;
            rfid1.Antenna_.Rows.Remove(gridView3.GetFocusedDataRow());
       //     rfid1.Antenna_.Rows.Add(new object[] { server, "", null });

        }

        private void gridView3_MouseDown(object sender, MouseEventArgs e)
        {

            eventCount = eventCount + 1;  // increment event counter

            if (e.X > 0
               & e.X <  gridControl3.Width
               & e.Y > 0
               & e.Y <  gridControl3.Height)
          {
                gridControl3.DoDragDrop("Reader", DragDropEffects.Copy);

             
           }

        }

        private void btnReaderDelete_Click(object sender, EventArgs e)
        {
            rfid1.ReaderList.RemoveReaderListRow((DSSmartCity.ReaderListRow)gridView2.GetFocusedDataRow());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            object[] objs = new Object[panel1.Controls.Count];

            int i = 0;
            foreach (Control item in panel1.Controls)
            {
                if (item.ToString()=="RfidTest.UCTag" || item.ToString()=="RfidTest.UCReader")
                {
                     objs[i] = item;
                     i++;
                }
           
                
            }

            foreach (Control item in objs)
            {
                panel1.Controls.Remove(item);
            }

            foreach (DSSmartCity.Antenna_Row item in rfid1.Antenna_.Rows)
            {
                item.x = 0 ;
                item.y = 0;

                SaveData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "photo|*.jpg;*.png;*.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(@fName);
                

              //  pictureBox1.ImageLocation = "";
                try
                {
                    System.IO.File.WriteAllBytes(@"photo/floor.png", System.IO.File.ReadAllBytes(@fName));

                }
                catch (Exception ex)
                {

                    MessageBox.Show("the floor image is in use, please close the system, and retry..."); ;
                }
             //   pictureBox1.BackgroundImage = Image.FromFile(@fName);
           

            }
      
        }

        private void btntagdelete_Click(object sender, EventArgs e)
        {

            rfid1.TagList.Rows.Remove(gridView1.GetFocusedDataRow());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        //    MessageBox.Show(e.Location.ToString());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
         //   MessageBox.Show(e.Location.ToString());
        
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location.ToString());
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
       
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("picturebox:"+e.Location.ToString());

            //scrollx = e.X;
            //scrolly = e.Y;

            //Console.WriteLine("Cursor:"+ Cursor.Position.ToString());
            
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine(e.ScrollOrientation+ " :"+ e.NewValue.ToString());
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
            {
                scrollx = e.NewValue;
            }
            else
            {
                scrolly = e.NewValue;
            }
        }

        private void btnReaderRefresh_Click(object sender, EventArgs e)
        {

        }
        private int _totalTags;
        private int _currentTags;

        private void AddTags(int r, int jiao, int jiao2, int i, string icon, string name, int readerx, int readery)
        {
            double x, y;
            //double r = 100;
            //int jiao = 0;
            //int jiao2 = 120;
            //10 as the qty

            //for (int i = 0; i < 10; i++)
            //{


            x = r * Math.Cos(jiao + i * jiao2) + readerx;
            y = r * Math.Sin(jiao + i * jiao2) + readery;

            int xx = int.Parse((Math.Round(x)).ToString());
            int yy = int.Parse((Math.Round(y)).ToString());

            UCTag mytag = new UCTag(icon, name);
            //  PictureBox mytag = new PictureBox();
            //   mytag.Image = im;

            mytag.AutoSize = true;
            mytag.Tag = "Tag";
            mytag.BackgroundImageLayout = ImageLayout.Stretch;
            mytag.Location = new System.Drawing.Point(xx, yy);
            //  mytag.Name = name.Split(',')[0].ToString();
            mytag.Size = new System.Drawing.Size(25, 35);
            mytag.BackColor = Color.Transparent;
           

            this.panel1.Controls.Add(mytag);
            mytag.BringToFront();
            //System.Windows.Forms.TextBox textBox3;
            //textBox3 = new System.Windows.Forms.TextBox();

            //textBox3.Location = new System.Drawing.Point(xx, yy);
            //textBox3.Name = "textBox1";
            //textBox3.Size = new System.Drawing.Size(27, 20);
            //textBox3.TabIndex = 0;
            //textBox3.BackColor = Color.Red;

            //this.Controls.Add(textBox3);

            //}
        }

    

      }
    }
