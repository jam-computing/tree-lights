using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree_Scanner;

namespace TreeGUI {
    public partial class formMain : Form {
        public formMain() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        // btnSetupTree
        private void button1_Click(object sender, EventArgs e) {
            var activeForm = ActiveForm as formMaster;
            // Set size to size of Scanner
            activeForm!.Size = new Size(701, 605);
            activeForm!.MaximizeBox = false;
            activeForm!.DisplayForm(new formWelcome());

        }

        private void btnViewFrames_Click(object sender, EventArgs e) {

        }

        private void btnViewAnimations_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formViewAnimations());

        private void btnSendToTree_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formSendToTree());

        private void formMain_Load(object sender, EventArgs e) {

        }

        private void btnViewMinecraft_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)!.Size = new Size(1000, 600);
            (ActiveForm as formMaster)!.DisplayForm(new ViewMinecraftImage());
        }
    }
}
