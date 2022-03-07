using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeCheater.Plugin.Screenshoter.Controls {
    public partial class ControlScreenshotBox : XtraUserControl {
        public ControlScreenshotBox(Image img) {
            InitializeComponent();
            ScreenBox.Image = img;
        }

        private void ControlScreenshotBox_Load(object sender, EventArgs e) {

        }
    }
}
