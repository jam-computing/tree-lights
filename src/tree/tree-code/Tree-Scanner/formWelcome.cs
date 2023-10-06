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
    public partial class formWelcome : Form {
        public formWelcome() {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(new formInfo());
        }
    }
}
