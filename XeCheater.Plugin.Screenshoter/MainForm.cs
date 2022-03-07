using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using XeCheater.Shared;

namespace XeCheater.Plugin.Screenshoter {
    public partial class MainForm : XtraForm {
        static string currdate = DateTime.Now.ToString("MM.dd.yyyy");
        string Screenshots = Path.Combine(Constants.AppData, "XeCheater", "Screenshots");
        string currimagepath = Path.Combine(Constants.AppData, "XeCheater", "Screenshots", $"{currdate}");
        public MainForm() {
            InitializeComponent();
            if (!Directory.Exists(Screenshots))
                Directory.CreateDirectory(Screenshots);

            if (!Directory.Exists(Path.Combine(Screenshots, currdate)))
                Directory.CreateDirectory(Path.Combine(Screenshots, currdate));
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void btnDoScreenshot_Click(object sender, EventArgs e) {
            DoScreenshot();
        }

        public void DoScreenshot() {
            if (!XboxVars.IsConnected)
                throw new Exception($"you are not connected to {XboxVars.xbMgr.DefaultConsole}");

            string path = Path.Combine(currimagepath, string.Format("XeCheater-{0}{1}", Utils.RandomString(6), ".bmp"));
            XboxVars.xbCon.ScreenShot(path);

            Image img = Image.FromFile(path);

            var embed = new Controls.ControlScreenshotBox(img)
            {
                Dock = System.Windows.Forms.DockStyle.Top
            };

            xtraScrollableControl1.Controls.Add(embed);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e) {
            Process.Start(Screenshots);
        }

        private void btnLoadScreenshot_Click(object sender, EventArgs e) {
            xtraScrollableControl1.Controls.Clear();
            foreach (var screenshotFolder in Directory.EnumerateDirectories(Screenshots)) {
                foreach(var screenshot in Directory.EnumerateFiles(screenshotFolder)) {
                    Image img = Image.FromFile(screenshot);

                    var embed = new Controls.ControlScreenshotBox(img) {
                        Dock = System.Windows.Forms.DockStyle.Top
                    };

                    xtraScrollableControl1.Controls.Add(embed);
                }
            }
        }
    }
}