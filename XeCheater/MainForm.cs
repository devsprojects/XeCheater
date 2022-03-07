using System;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using XeCheater.Interfaces;
using XeCheater.Shared;
using System.IO;

namespace XeCheater {
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm {
        PluginLoader pluginLoader = new PluginLoader();
        private INI config = new INI(Path.Combine(Constants.AppData, "XeCheater", "XeCheater.ini"));

        private void Setup() {
            if (!Directory.Exists(Path.Combine(Constants.AppData, "XeCheater"))) {
                Directory.CreateDirectory(Path.Combine(Constants.AppData, "XeCheater"));
            }

            if (!File.Exists(Path.Combine(Constants.AppData, "XeCheater", "XeCheater.ini")))
                config.DefaultConfig();
        }


        public MainForm() {
            InitializeComponent();
            Setup();
        }

        private async void MainForm_Load(object sender, EventArgs e) {
            await pluginLoader.LoadPlugins(Constants.PluginFolder);

            if (pluginLoader.plugins.Count == 0)
                XtraMessageBox.Show("no plugins found!", "XeCheater Plugins System");
            else {
                foreach (IPlugin plugin in pluginLoader.plugins) {
                    AccordionControlElement NavPluginItem = new AccordionControlElement();
                    NavPluginItem.Tag = plugin;
                    NavPluginItem.Text = plugin.Name;
                    NavPluginItem.Click += NavPluginItemClick_Event;
                    NavPluginItem.Style = ElementStyle.Item;

                    NavgroupPlugins.Elements.Add(NavPluginItem);
                }
            }

            if(config.KeyExists("Auto Connect", "Xbox Connection") && config.Read("Auto Connect", "Xbox Connection") == "true") {
                if (xbFunction.Connect()) {
                    Utils.Notify("Xbox Connection!", $"Connected to {XboxVars.xbCon.Name}", ToolTipIcon.Info);
                }
            }
        }

        private void NavPluginItemClick_Event(object sender, EventArgs e) {
            IPlugin plugin = (sender as AccordionControlElement).Tag as IPlugin;
            plugin.Form.Show();
        }

        private void NavBarConnect_Click(object sender, EventArgs e) {
            try {
                if (xbFunction.Connect())
                    Utils.Notify("Xbox Connection!", $"Connected to {XboxVars.xbCon.Name}", ToolTipIcon.Info);
            }
            catch(Exception ex) {
                XtraMessageBox.Show($"Exception: {ex.Message}", "Error");
            }
        }

        private void NavBarDisconnect_Click(object sender, EventArgs e) {
            xbFunction.Disconnect();
            Utils.Notify("Xbox Connection!", $"Disconnected!", ToolTipIcon.Info);
        }
    }
}
