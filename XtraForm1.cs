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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.company' table. You can move, or remove it, as needed.
        //   DataSet1.companyDataTable ct =new DataSet1.companyDataTable();

         //  DataSet1TableAdapters.companyTableAdapter myAdapter=new SmartCity.DataSet1TableAdapters.companyTableAdapter();
          //  myAdapter.Fill(dataSet11.company);
            

        }
    }
}