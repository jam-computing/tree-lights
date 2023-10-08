using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeAPI;
using Newtonsoft.Json;
using TreeAPI.Types;
using TreeAPI.Config;

namespace TreeGUI
{
    public partial class formSendToTree : Form
    {

        private string animationDirectory = "../../../../../../../data/animations/";
        private string frameDirectory = "../../../../../../../data/frames/";
        private List<string> AllSendables = new();
        private Tree tree = new();
        public formSendToTree()
        {

            TreeConfig config = TreeConfig.GetConfig() as TreeConfig;

            tree = new Tree(new IpAddr(config.IP, config.Port, "Text"));

            if (tree.IsConnected is false)
            {
                MessageBox.Show("No TreeServer found. Try editing the config.json");
                tree.Dispose();
                (ActiveForm as formMaster)!.DisplayForm(new formMain());
            }
            else MessageBox.Show("Connected to server!");

            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            GetFileNames();
            foreach (var sendable in AllSendables)
            {
                listBox1.Items.Add(sendable);
            }
        }

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            btnSend.Text = $"Send: {AllSendables[listBox1.SelectedIndex].Split("\\")[^1].Split(".")[0]}";
        }

        private void listBox1_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches) return;
        }

        private void GetFileNames()
        {
            foreach (var file in Directory.EnumerateFiles(frameDirectory, "*.*", SearchOption.AllDirectories))
                AllSendables.Add(file.Split("/")[^1]);

            foreach (var file in Directory.EnumerateFiles(animationDirectory, "*.*", SearchOption.AllDirectories))
                AllSendables.Add(file.Split("/")[^1]);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.Select == null) return;
            string sendingOption = listBox1.Items[listBox1.SelectedIndex].ToString()!.Split("\\")[^1];
            // Need to get data of file
            tree.Send(sendingOption);
            btnSend.Text = sendingOption;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tree.IsConnected) tree.Dispose();
            (ActiveForm as formMaster)!.DisplayForm(new formMain());
        }
    }
}
