using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeGUI {
    public partial class formViewAnimations : Form {
        private string directory = "../../../../../../../data/animations/";
        private List<string> fileNames = new();
        public formViewAnimations() {
            InitializeComponent();
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            listBox1.Items.Clear();
            GetAllFiles();
            foreach (var i in fileNames) listBox1.Items.Add(i + "\n");
        }

        private void listBox1_MouseDoubleClick(object? sender, MouseEventArgs e) {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches) return;

            string name = fileNames[index];

            Form animationData = new ViewAnimationCode(GetAnimation(name));

            animationData.Show();
        }

        private string[] GetAnimation(string name) =>
             File.ReadAllLines(directory + name);

        private void GetAllFiles() {
            foreach (var file in Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories))
                fileNames.Add(file.Split("/")[^1]);
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(new formMain());
        }
    }
}
