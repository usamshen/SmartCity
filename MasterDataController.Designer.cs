namespace SmartCity
{
    partial class MasterDataController
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.smartCity1 = new SmartCity.DatasetSmartCity();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKControllerArea1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAreaName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colControllerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colRoadName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaodName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaodName3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colx1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coly1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collastupdated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // smartCity1
            // 
            this.smartCity1.DataSetName = "DatasetSmartCity";
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
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl3.DataMember = "Area";
            this.gridControl3.DataSource = this.smartCity1;
            this.gridControl3.Location = new System.Drawing.Point(12, 12);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(173, 430);
            this.gridControl3.TabIndex = 28;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAreaName1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.AllowZoomDetail = false;
            this.gridView3.OptionsDetail.EnableMasterViewMode = false;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsDetail.SmartDetailExpand = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.RowAutoHeight = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colAreaName1
            // 
            this.colAreaName1.Caption = "区域名";
            this.colAreaName1.FieldName = "AreaName";
            this.colAreaName1.Name = "colAreaName1";
            this.colAreaName1.Visible = true;
            this.colAreaName1.VisibleIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(593, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(694, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 26;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "Area.FK_Controller_Area1";
            this.gridControl2.DataSource = this.smartCity1;
            this.gridControl2.Location = new System.Drawing.Point(191, 12);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox2});
            this.gridControl2.Size = new System.Drawing.Size(599, 430);
            this.gridControl2.TabIndex = 25;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colControllerName1,
            this.colArea,
            this.colRoadName1,
            this.colRaodName2,
            this.colRaodName3,
            this.colSIM,
            this.colx1,
            this.coly1,
            this.coldescription1,
            this.collastupdated});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.AllowZoomDetail = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsDetail.SmartDetailExpand = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colControllerName1
            // 
            this.colControllerName1.Caption = "控制器名";
            this.colControllerName1.FieldName = "ControllerName";
            this.colControllerName1.Name = "colControllerName1";
            this.colControllerName1.Visible = true;
            this.colControllerName1.VisibleIndex = 0;
            // 
            // colArea
            // 
            this.colArea.Caption = "区域";
            this.colArea.ColumnEdit = this.repositoryItemComboBox2;
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 1;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // colRoadName1
            // 
            this.colRoadName1.Caption = "道路1";
            this.colRoadName1.FieldName = "RoadName1";
            this.colRoadName1.Name = "colRoadName1";
            this.colRoadName1.Visible = true;
            this.colRoadName1.VisibleIndex = 2;
            // 
            // colRaodName2
            // 
            this.colRaodName2.Caption = "道路2";
            this.colRaodName2.FieldName = "RaodName2";
            this.colRaodName2.Name = "colRaodName2";
            this.colRaodName2.Visible = true;
            this.colRaodName2.VisibleIndex = 3;
            // 
            // colRaodName3
            // 
            this.colRaodName3.Caption = "道路3";
            this.colRaodName3.FieldName = "RaodName3";
            this.colRaodName3.Name = "colRaodName3";
            this.colRaodName3.Visible = true;
            this.colRaodName3.VisibleIndex = 4;
            // 
            // colSIM
            // 
            this.colSIM.Caption = "SIM号码";
            this.colSIM.FieldName = "SIM";
            this.colSIM.Name = "colSIM";
            this.colSIM.Visible = true;
            this.colSIM.VisibleIndex = 5;
            // 
            // colx1
            // 
            this.colx1.Caption = "x";
            this.colx1.FieldName = "x";
            this.colx1.Name = "colx1";
            this.colx1.Visible = true;
            this.colx1.VisibleIndex = 6;
            // 
            // coly1
            // 
            this.coly1.Caption = "y";
            this.coly1.FieldName = "y";
            this.coly1.Name = "coly1";
            this.coly1.Visible = true;
            this.coly1.VisibleIndex = 7;
            // 
            // coldescription1
            // 
            this.coldescription1.Caption = "描述";
            this.coldescription1.FieldName = "description";
            this.coldescription1.Name = "coldescription1";
            this.coldescription1.Visible = true;
            this.coldescription1.VisibleIndex = 8;
            // 
            // collastupdated
            // 
            this.collastupdated.Caption = "最后更新时间";
            this.collastupdated.FieldName = "lastupdated";
            this.collastupdated.Name = "collastupdated";
            this.collastupdated.Visible = true;
            this.collastupdated.VisibleIndex = 9;
            // 
            // MasterDataController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 494);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gridControl2);
            this.Name = "MasterDataController";
            this.Text = "控制器设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterDataController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatasetSmartCity smartCity1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.BindingSource fKControllerArea1BindingSource;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaName1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colControllerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadName1;
        private DevExpress.XtraGrid.Columns.GridColumn colRaodName2;
        private DevExpress.XtraGrid.Columns.GridColumn colRaodName3;
        private DevExpress.XtraGrid.Columns.GridColumn colSIM;
        private DevExpress.XtraGrid.Columns.GridColumn colx1;
        private DevExpress.XtraGrid.Columns.GridColumn coly1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription1;
        private DevExpress.XtraGrid.Columns.GridColumn collastupdated;

    }
}