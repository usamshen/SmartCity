namespace SmartCity
{
    partial class XtraForm1
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
           
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col编号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col类型 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col附件一 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col附件一描述 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col附件二 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col附件二描述 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col附件三 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col变量4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col变量5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col最后更新时间 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col最后更新人 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl3
            // 
            this.gridControl3.DataMember = "company";
            this.gridControl3.DataSource = this.dataSet11;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(497, 389);
            this.gridControl3.TabIndex = 23;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col编号,
            this.col类型,
            this.col名称,
            this.col附件一,
            this.col附件一描述,
            this.col附件二,
            this.col附件二描述,
            this.col附件三,
            this.col变量4,
            this.col变量5,
            this.col最后更新时间,
            this.col最后更新人});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // col编号
            // 
            this.col编号.FieldName = "编号";
            this.col编号.Name = "col编号";
            this.col编号.Visible = true;
            this.col编号.VisibleIndex = 0;
            // 
            // col类型
            // 
            this.col类型.FieldName = "类型";
            this.col类型.Name = "col类型";
            this.col类型.Visible = true;
            this.col类型.VisibleIndex = 1;
            // 
            // col名称
            // 
            this.col名称.FieldName = "名称";
            this.col名称.Name = "col名称";
            this.col名称.Visible = true;
            this.col名称.VisibleIndex = 2;
            // 
            // col附件一
            // 
            this.col附件一.FieldName = "附件一";
            this.col附件一.Name = "col附件一";
            this.col附件一.Visible = true;
            this.col附件一.VisibleIndex = 3;
            // 
            // col附件一描述
            // 
            this.col附件一描述.FieldName = "附件一描述";
            this.col附件一描述.Name = "col附件一描述";
            this.col附件一描述.Visible = true;
            this.col附件一描述.VisibleIndex = 4;
            // 
            // col附件二
            // 
            this.col附件二.FieldName = "附件二";
            this.col附件二.Name = "col附件二";
            this.col附件二.Visible = true;
            this.col附件二.VisibleIndex = 5;
            // 
            // col附件二描述
            // 
            this.col附件二描述.FieldName = "附件二描述";
            this.col附件二描述.Name = "col附件二描述";
            this.col附件二描述.Visible = true;
            this.col附件二描述.VisibleIndex = 6;
            // 
            // col附件三
            // 
            this.col附件三.FieldName = "附件三";
            this.col附件三.Name = "col附件三";
            this.col附件三.Visible = true;
            this.col附件三.VisibleIndex = 7;
            // 
            // col变量4
            // 
            this.col变量4.FieldName = "变量4";
            this.col变量4.Name = "col变量4";
            this.col变量4.Visible = true;
            this.col变量4.VisibleIndex = 8;
            // 
            // col变量5
            // 
            this.col变量5.FieldName = "变量5";
            this.col变量5.Name = "col变量5";
            this.col变量5.Visible = true;
            this.col变量5.VisibleIndex = 9;
            // 
            // col最后更新时间
            // 
            this.col最后更新时间.FieldName = "最后更新时间";
            this.col最后更新时间.Name = "col最后更新时间";
            this.col最后更新时间.Visible = true;
            this.col最后更新时间.VisibleIndex = 10;
            // 
            // col最后更新人
            // 
            this.col最后更新人.FieldName = "最后更新人";
            this.col最后更新人.Name = "col最后更新人";
            this.col最后更新人.Visible = true;
            this.col最后更新人.VisibleIndex = 11;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 423);
            this.Controls.Add(this.gridControl3);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn col编号;
        private DevExpress.XtraGrid.Columns.GridColumn col类型;
        private DevExpress.XtraGrid.Columns.GridColumn col名称;
        private DevExpress.XtraGrid.Columns.GridColumn col附件一;
        private DevExpress.XtraGrid.Columns.GridColumn col附件一描述;
        private DevExpress.XtraGrid.Columns.GridColumn col附件二;
        private DevExpress.XtraGrid.Columns.GridColumn col附件二描述;
        private DevExpress.XtraGrid.Columns.GridColumn col附件三;
        private DevExpress.XtraGrid.Columns.GridColumn col变量4;
        private DevExpress.XtraGrid.Columns.GridColumn col变量5;
        private DevExpress.XtraGrid.Columns.GridColumn col最后更新时间;
        private DevExpress.XtraGrid.Columns.GridColumn col最后更新人;
    }
}