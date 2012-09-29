namespace SmartCity
{
    
    partial class MasterDataArea
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.smartCity1 = new SmartCity.DatasetSmartCity();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKControllerArea1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAreaName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colscale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastupdatetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colupdatedby = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // smartCity1
            // 
            this.smartCity1.DataSetName = "rfid";
            this.smartCity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.smartCity1;
            // 
            // fKControllerArea1BindingSource
            // 
            this.fKControllerArea1BindingSource.DataMember = "FK_Controller_Area1";
            this.fKControllerArea1BindingSource.DataSource = this.areaBindingSource;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(595, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(696, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 34);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Area";
            this.gridControl1.DataSource = this.smartCity1;
            this.gridControl1.Location = new System.Drawing.Point(3, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(788, 517);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAreaName2,
            this.colMap,
            this.colscale,
            this.collong,
            this.colwide,
            this.colDescription2,
            this.collastupdatetime,
            this.colupdatedby});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsDetail.SmartDetailExpand = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colAreaName2
            // 
            this.colAreaName2.Caption = "区域名";
            this.colAreaName2.FieldName = "AreaName";
            this.colAreaName2.Name = "colAreaName2";
            this.colAreaName2.Visible = true;
            this.colAreaName2.VisibleIndex = 0;
            // 
            // colMap
            // 
            this.colMap.Caption = "地图";
            this.colMap.FieldName = "Map";
            this.colMap.Name = "colMap";
            this.colMap.OptionsColumn.AllowEdit = false;
            this.colMap.Visible = true;
            this.colMap.VisibleIndex = 1;
            // 
            // colscale
            // 
            this.colscale.Caption = "比例尺";
            this.colscale.FieldName = "scale";
            this.colscale.Name = "colscale";
            this.colscale.Visible = true;
            this.colscale.VisibleIndex = 2;
            // 
            // collong
            // 
            this.collong.Caption = "长";
            this.collong.FieldName = "long";
            this.collong.Name = "collong";
            this.collong.Visible = true;
            this.collong.VisibleIndex = 3;
            // 
            // colwide
            // 
            this.colwide.Caption = "宽";
            this.colwide.FieldName = "wide";
            this.colwide.Name = "colwide";
            this.colwide.Visible = true;
            this.colwide.VisibleIndex = 4;
            // 
            // colDescription2
            // 
            this.colDescription2.Caption = "描述";
            this.colDescription2.FieldName = "Description";
            this.colDescription2.Name = "colDescription2";
            this.colDescription2.Visible = true;
            this.colDescription2.VisibleIndex = 5;
            // 
            // collastupdatetime
            // 
            this.collastupdatetime.Caption = "更新时间";
            this.collastupdatetime.FieldName = "lastupdatetime";
            this.collastupdatetime.Name = "collastupdatetime";
            this.collastupdatetime.Visible = true;
            this.collastupdatetime.VisibleIndex = 6;
            // 
            // colupdatedby
            // 
            this.colupdatedby.Caption = "更新人";
            this.colupdatedby.FieldName = "updatedby";
            this.colupdatedby.Name = "colupdatedby";
            this.colupdatedby.Visible = true;
            this.colupdatedby.VisibleIndex = 7;
            // 
            // MasterDataArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridControl1);
            this.Name = "MasterDataArea";
            this.Text = "区域设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatasetSmartCity smartCity1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.BindingSource fKControllerArea1BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaName2;
        private DevExpress.XtraGrid.Columns.GridColumn colMap;
        private DevExpress.XtraGrid.Columns.GridColumn colscale;
        private DevExpress.XtraGrid.Columns.GridColumn collong;
        private DevExpress.XtraGrid.Columns.GridColumn colwide;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription2;
        private DevExpress.XtraGrid.Columns.GridColumn collastupdatetime;
        private DevExpress.XtraGrid.Columns.GridColumn colupdatedby;

    }
}