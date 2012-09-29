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
    public partial class MasterDataLight : DevExpress.XtraEditors.XtraForm
    {
        public MasterDataLight()
        {
            InitializeComponent();
            (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
            (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

            (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);

            (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.LightTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.LightTableAdapter();
            myadp.Update(smartCity1);
        }

        private void MasterDataLight_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“smartCity1.Controller”中。您可以根据需要移动或删除它。
       //     this.controllerTableAdapter.Fill(this.smartCity1.Controller);



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

        private void button4_Click(object sender, EventArgs e)
        {
            gridView6.DeleteSelectedRows();
        }

        private void gridControl5_Click(object sender, EventArgs e)
        {

        }
    }
}