namespace SmartCity
{
    partial class UCLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taglabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xcsdfsdfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taglabel
            // 
            this.taglabel.AutoSize = true;
            this.taglabel.BackColor = System.Drawing.Color.White;
            this.taglabel.ForeColor = System.Drawing.Color.Red;
            this.taglabel.Location = new System.Drawing.Point(-3, 0);
            this.taglabel.Name = "taglabel";
            this.taglabel.Size = new System.Drawing.Size(30, 13);
            this.taglabel.TabIndex = 1;
            this.taglabel.Text = "chair";
            this.taglabel.Click += new System.EventHandler(this.taglabel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcsdfsdfsdfToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // xcsdfsdfsdfToolStripMenuItem
            // 
            this.xcsdfsdfsdfToolStripMenuItem.Name = "xcsdfsdfsdfToolStripMenuItem";
            this.xcsdfsdfsdfToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.xcsdfsdfsdfToolStripMenuItem.Text = "xcsdfsdfsdf";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.taglabel);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 16);
            this.panel1.TabIndex = 3;
            // 
            // UCLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "UCLight";
            this.Size = new System.Drawing.Size(37, 37);
            this.Load += new System.EventHandler(this.Usertag_Load);
            this.DoubleClick += new System.EventHandler(this.UCLight_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.UCLight_MouseEnter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taglabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xcsdfsdfsdfToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}
