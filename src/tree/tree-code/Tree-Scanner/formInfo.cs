using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_Scanner {
    public partial class formInfo : Form {
        public formInfo() {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(new formTreePhoto());
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(new formWelcome());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                buttonNext.Enabled = true;
            }
            else {
                buttonNext.Enabled = false;
            }
        }
    }
}
