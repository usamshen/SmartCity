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
    public partial class MasterDataProduct : DevExpress.XtraEditors.XtraForm
    {
        public MasterDataProduct()
        {
            InitializeComponent();
            (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
            (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

            (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);

            (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.ProductTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.ProductTableAdapter();
            myadp.Update(smartCity1);
        }

        private void MasterDataProduct_Load(object sender, EventArgs e)
        {
            repositoryItemComboBox1.Items.Clear();
            foreach (DatasetSmartCity.TypeRow item in smartCity1.Type.Rows)
            {
                repositoryItemComboBox1.Items.Add(item.Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gridView10.DeleteSelectedRows();
        }
    }
}