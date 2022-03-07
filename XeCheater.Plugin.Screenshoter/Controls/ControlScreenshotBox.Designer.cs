namespace XeCheater.Plugin.Screenshoter.Controls
{
    partial class ControlScreenshotBox
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
            this.ScreenBox = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ScreenBox
            // 
            this.ScreenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenBox.Location = new System.Drawing.Point(0, 0);
            this.ScreenBox.Name = "ScreenBox";
            this.ScreenBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ScreenBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ScreenBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ScreenBox.Size = new System.Drawing.Size(925, 389);
            this.ScreenBox.TabIndex = 0;
            // 
            // ControlScreenshotBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScreenBox);
            this.Name = "ControlScreenshotBox";
            this.Size = new System.Drawing.Size(925, 389);
            this.Load += new System.EventHandler(this.ControlScreenshotBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit ScreenBox;
    }
}
