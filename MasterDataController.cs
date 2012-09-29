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
    public partial class MasterDataController : DevExpress.XtraEditors.XtraForm
    {
        public MasterDataController()
        {
            InitializeComponent();
            (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
            (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

            (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);

            (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.ControllerTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.ControllerTableAdapter();
            myadp.Update(smartCity1);
        }

        private void MasterDataController_Load(object sender, EventArgs e)
        {
            repositoryItemComboBox2.Items.Clear();
            foreach (DatasetSmartCity.AreaRow item in smartCity1.Area.Rows)
            {
                repositoryItemComboBox2.Items.Add(item.AreaName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }
    }
}