namespace XeCheater.Plugin.Screenshoter
{
    partial class MainForm
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnOpenFolder = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoScreenshot = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadScreenshot = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(925, 404);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraScrollableControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 35);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(929, 408);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnLoadScreenshot);
            this.panelControl2.Controls.Add(this.btnOpenFolder);
            this.panelControl2.Controls.Add(this.btnDoScreenshot);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(929, 35);
            this.panelControl2.TabIndex = 2;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenFolder.Location = new System.Drawing.Point(193, 2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOpenFolder.Size = new System.Drawing.Size(191, 31);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnDoScreenshot
            // 
            this.btnDoScreenshot.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDoScreenshot.Location = new System.Drawing.Point(2, 2);
            this.btnDoScreenshot.Name = "btnDoScreenshot";
            this.btnDoScreenshot.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDoScreenshot.Size = new System.Drawing.Size(191, 31);
            this.btnDoScreenshot.TabIndex = 0;
            this.btnDoScreenshot.Text = "Screenshot";
            this.btnDoScreenshot.Click += new System.EventHandler(this.btnDoScreenshot_Click);
            // 
            // btnLoadScreenshot
            // 
            this.btnLoadScreenshot.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadScreenshot.Location = new System.Drawing.Point(384, 2);
            this.btnLoadScreenshot.Name = "btnLoadScreenshot";
            this.btnLoadScreenshot.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnLoadScreenshot.Size = new System.Drawing.Size(191, 31);
            this.btnLoadScreenshot.TabIndex = 2;
            this.btnLoadScreenshot.Text = "Load Screenshots";
            this.btnLoadScreenshot.Click += new System.EventHandler(this.btnLoadScreenshot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 443);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::XeCheater.Plugin.Screenshoter.Properties.Resources.Logo;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XeCheater - Screenshoter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDoScreenshot;
        private DevExpress.XtraEditors.SimpleButton btnOpenFolder;
        private DevExpress.XtraEditors.SimpleButton btnLoadScreenshot;
    }
}