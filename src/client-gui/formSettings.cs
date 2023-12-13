using System.Diagnostics;
using TreeAPI.Config;

namespace TreeGUI
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void btnMincraftConfig_Click(object sender, EventArgs e) =>
            Process.Start("notepad.exe", MinecraftConfig.ConfigFile);

        private void btnIpConfig_Click(object sender, EventArgs e) =>
            Process.Start("notepad.exe", ClientConfig.ConfigFile);

        private void btnBack_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formHome());

    }
}
