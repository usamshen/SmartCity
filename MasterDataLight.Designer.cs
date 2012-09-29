namespace SmartCity
{
    partial class MasterDataLight
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLightName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontroller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colRoad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fKControllerLightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colControllerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controllerTableAdapter = new SmartCity.DatasetSmartCityTableAdapters.ControllerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerLightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(606, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 34);
            this.button4.TabIndex = 34;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(707, 551);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 34);
            this.button5.TabIndex = 33;
            this.button5.Text = "保存";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gridControl6
            // 
            this.gridControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl6.DataMember = "Controller.FK_Light_Controller1";
            this.gridControl6.DataSource = this.smartCity1;
            this.gridControl6.Location = new System.Drawing.Point(264, 12);
            this.gridControl6.MainView = this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4});
            this.gridControl6.Size = new System.Drawing.Size(534, 533);
            this.gridControl6.TabIndex = 32;
            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLightName,
            this.colProductName,
            this.colx,
            this.coly,
            this.colcontroller,
            this.colRoad,
            this.colDescription});
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView6.OptionsView.RowAutoHeight = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colLightName
            // 
            this.colLightName.Caption = "路灯号";
            this.colLightName.FieldName = "LightName";
            this.colLightName.Name = "colLightName";
            this.colLightName.Visible = true;
            this.colLightName.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "产品名称";
            this.colProductName.ColumnEdit = this.repositoryItemComboBox3;
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 6;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // colx
            // 
            this.colx.Caption = "x";
            this.colx.FieldName = "x";
            this.colx.Name = "colx";
            this.colx.Visible = true;
            this.colx.VisibleIndex = 1;
            // 
            // coly
            // 
            this.coly.FieldName = "y";
            this.coly.Name = "coly";
            this.coly.Visible = true;
            this.coly.VisibleIndex = 2;
            // 
            // colcontroller
            // 
            this.colcontroller.Caption = "控制器";
            this.colcontroller.ColumnEdit = this.repositoryItemComboBox4;
            this.colcontroller.FieldName = "controller";
            this.colcontroller.Name = "colcontroller";
            this.colcontroller.Visible = true;
            this.colcontroller.VisibleIndex = 3;
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // colRoad
            // 
            this.colRoad.Caption = "道路";
            this.colRoad.FieldName = "Road";
            this.colRoad.Name = "colRoad";
            this.colRoad.Visible = true;
            this.colRoad.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // gridControl5
            // 
            this.gridControl5.DataMember = "Controller";
            this.gridControl5.DataSource = this.smartCity1;
            this.gridControl5.Location = new System.Drawing.Point(12, 12);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(246, 530);
            this.gridControl5.TabIndex = 30;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gridControl5.Click += new System.EventHandler(this.gridControl5_Click);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colControllerName,
            this.colArea,
            this.colRoadName1});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.GroupCount = 1;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsDetail.EnableMasterViewMode = false;
            this.gridView5.OptionsDetail.ShowDetailTabs = false;
            this.gridView5.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            this.gridView5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView5.OptionsView.RowAutoHeight = true;
            this.gridView5.OptionsView.ShowDetailButtons = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colArea, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colControllerName
            // 
            this.colControllerName.Caption = "控制器名字";
            this.colControllerName.FieldName = "ControllerName";
            this.colControllerName.Name = "colControllerName";
            this.colControllerName.Visible = true;
            this.colControllerName.VisibleIndex = 0;
            // 
            // colArea
            // 
            this.colArea.Caption = "区域名";
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 1;
            // 
            // colRoadName1
            // 
            this.colRoadName1.Caption = "路名";
            this.colRoadName1.FieldName = "RoadName1";
            this.colRoadName1.Name = "colRoadName1";
            this.colRoadName1.Visible = true;
            this.colRoadName1.VisibleIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Controller";
            this.bindingSource1.DataSource = this.smartCity1;
            // 
            // controllerTableAdapter
            // 
            this.controllerTableAdapter.ClearBeforeFill = true;
            // 
            // MasterDataLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 597);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gridControl6);
            this.Controls.Add(this.gridControl5);
            this.Name = "MasterDataLight";
            this.Text = "路灯设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterDataLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerLightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatasetSmartCity smartCity1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.BindingSource fKControllerArea1BindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraGrid.GridControl gridControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colLightName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraGrid.Columns.GridColumn colx;
        private DevExpress.XtraGrid.Columns.GridColumn coly;
        private DevExpress.XtraGrid.Columns.GridColumn colcontroller;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraGrid.Columns.GridColumn colRoad;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.BindingSource fKControllerLightBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DatasetSmartCityTableAdapters.ControllerTableAdapter controllerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colControllerName;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadName1;

    }
}