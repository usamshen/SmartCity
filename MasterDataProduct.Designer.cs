namespace SmartCity
{
    partial class MasterDataProduct
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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gridControl8 = new DevExpress.XtraGrid.GridControl();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
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
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(618, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 34);
            this.button6.TabIndex = 26;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(687, 445);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 34);
            this.button7.TabIndex = 25;
            this.button7.Text = "保存";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // gridControl8
            // 
            this.gridControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl8.DataMember = "Product";
            this.gridControl8.DataSource = this.smartCity1;
            this.gridControl8.Location = new System.Drawing.Point(-18, 12);
            this.gridControl8.MainView = this.gridView10;
            this.gridControl8.Name = "gridControl8";
            this.gridControl8.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl8.Size = new System.Drawing.Size(764, 427);
            this.gridControl8.TabIndex = 24;
            this.gridControl8.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView10});
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colphoto,
            this.coltype});
            this.gridView10.GridControl = this.gridControl8;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsDetail.AllowZoomDetail = false;
            this.gridView10.OptionsDetail.EnableMasterViewMode = false;
            this.gridView10.OptionsDetail.ShowDetailTabs = false;
            this.gridView10.OptionsDetail.SmartDetailExpand = false;
            this.gridView10.OptionsView.ColumnAutoWidth = false;
            this.gridView10.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView10.OptionsView.RowAutoHeight = true;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "产品名字";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 127;
            // 
            // colphoto
            // 
            this.colphoto.Caption = "图片";
            this.colphoto.FieldName = "photo";
            this.colphoto.Name = "colphoto";
            this.colphoto.Visible = true;
            this.colphoto.VisibleIndex = 1;
            this.colphoto.Width = 124;
            // 
            // coltype
            // 
            this.coltype.Caption = "类型";
            this.coltype.ColumnEdit = this.repositoryItemComboBox1;
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 2;
            this.coltype.Width = 111;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // MasterDataProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 491);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.gridControl8);
            this.Name = "MasterDataProduct";
            this.Text = "MasterDataProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterDataProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatasetSmartCity smartCity1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.BindingSource fKControllerArea1BindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private DevExpress.XtraGrid.GridControl gridControl8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colphoto;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;

    }
}