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
    public partial class MasterData : DevExpress.XtraEditors.XtraForm
    {
        public MasterData()
        {
            InitializeComponent();
        }

        public MasterData(int type)
        {
            InitializeComponent();
            tabControl1.SelectTab(type);
             (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
             (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

            (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);
            
            (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            
           
            
          


            repositoryItemComboBox1.Items.Clear();
            foreach (DatasetSmartCity.TypeRow item in smartCity1.Type.Rows)
            {
                repositoryItemComboBox1.Items.Add(item.Name);
            }

            repositoryItemComboBox2.Items.Clear();
            foreach (DatasetSmartCity.AreaRow item in smartCity1.Area.Rows)
            {
                repositoryItemComboBox2.Items.Add(item.AreaName);
            }

            repositoryItemComboBox3.Items.Clear();
            foreach (DatasetSmartCity.ProductRow item in smartCity1.Product.Rows)
            {
                repositoryItemComboBox3.Items.Add(item.name);
            }

            repositoryItemComboBox4.Items.Clear();
            foreach (DatasetSmartCity.ControllerRow item in smartCity1.Controller.Rows)
            {
                repositoryItemComboBox4.Items.Add(item.ControllerName);
            }

            
        }


        private void MasterData_Load(object sender, EventArgs e)
        {
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.TypeTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.TypeTableAdapter();
            myadp.Update(smartCity1);

            repositoryItemComboBox1.Items.Clear();
            foreach (DatasetSmartCity.TypeRow item in smartCity1.Type.Rows)
	        {
                repositoryItemComboBox1.Items.Add(item.Name);
	        }
         

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.ProductTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.ProductTableAdapter();  
            myadp.Update(smartCity1);

            repositoryItemComboBox3.Items.Clear();
            foreach (DatasetSmartCity.ProductRow item in smartCity1.Product.Rows)
            {
                repositoryItemComboBox3.Items.Add(item.name);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.AreaTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.AreaTableAdapter();
            myadp.Update(smartCity1);

            repositoryItemComboBox2.Items.Clear();
            foreach (DatasetSmartCity.AreaRow item in smartCity1.Area.Rows)
            {
                repositoryItemComboBox2.Items.Add(item.AreaName);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.ControllerTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.ControllerTableAdapter();
            myadp.Update(smartCity1);

            repositoryItemComboBox4.Items.Clear();
            foreach (DatasetSmartCity.ControllerRow item in smartCity1.Controller.Rows)
            {
                repositoryItemComboBox4.Items.Add(item.ControllerName);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.LightTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.LightTableAdapter();
            myadp.Update(smartCity1);

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}