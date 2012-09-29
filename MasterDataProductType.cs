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
    public partial class MasterDataProductType : DevExpress.XtraEditors.XtraForm
    {
        public MasterDataProductType()
        {
            InitializeComponent();
        }

        private void MasterDataProductType_Load(object sender, EventArgs e)
        {
            (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
            (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
            (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

            (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);

            (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.TypeTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.TypeTableAdapter();
            myadp.Update(smartCity1);

        
         

        }

        private void button8_Click(object sender, EventArgs e)
        {
            gridView11.DeleteSelectedRows();
        }
    }
}