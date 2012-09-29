using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Web;
using System.IO;
using System.Net;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SmartCity
{
    public partial class MasterDataArea : DevExpress.XtraEditors.XtraForm
    {
        public MasterDataArea()
        {
            InitializeComponent();
            (new DatasetSmartCityTableAdapters.TypeTableAdapter()).Fill(smartCity1.Type);
            (new DatasetSmartCityTableAdapters.ProductTableAdapter()).Fill(smartCity1.Product);
            (new DatasetSmartCityTableAdapters.AreaTableAdapter()).Fill(smartCity1.Area);

            (new DatasetSmartCityTableAdapters.ControllerTableAdapter()).Fill(smartCity1.Controller);

            (new DatasetSmartCityTableAdapters.LightTableAdapter()).Fill(smartCity1.Light);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DatasetSmartCityTableAdapters.AreaTableAdapter myadp = new global::SmartCity.DatasetSmartCityTableAdapters.AreaTableAdapter();
            myadp.Update(smartCity1);
        }


        private void DoRowDoubleClick(GridView view, Point pt)
        {
            string fileToSelect = "地图";

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

                        System.IO.File.WriteAllBytes(@"photo/" + openFileDialog.SafeFileName, System.IO.File.ReadAllBytes(@fName));

                     //   view.SetFocusedValue(System.IO.File.ReadAllBytes(@fName));
                        gridView1.GetFocusedDataRow()[1] = openFileDialog.SafeFileName;//System.IO.File.ReadAllBytes(@fName);
                    }
                    else
                    {
                        view.SetFocusedValue(null);
                        gridView1.GetFocusedDataRow()[1] = null;


                    }
                }

            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;

            Point pt = view.GridControl.PointToClient(Control.MousePosition);

            DoRowDoubleClick(view, pt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }
    }
}