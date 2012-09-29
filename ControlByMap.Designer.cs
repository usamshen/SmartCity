namespace SmartCity
{
    partial class ControlByMap
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
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).BeginInit();
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
            // ControlByMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 431);
            this.Name = "ControlByMap";
            this.Text = "ControlByMap";
            ((System.ComponentModel.ISupportInitialize)(this.smartCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKControllerArea1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatasetSmartCity smartCity1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private System.Windows.Forms.BindingSource fKControllerArea1BindingSource;
    }
}