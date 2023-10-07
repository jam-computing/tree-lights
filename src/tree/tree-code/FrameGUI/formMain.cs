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

namespace TreeGUI
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // btnSetupTree
        private void button1_Click(object sender, EventArgs e)
        {
            var activeForm = ActiveForm as formMaster;
            activeForm!.Size = new Size(1000, 1000);
            activeForm!.MaximizeBox = false;
            activeForm!.DisplayForm(new formWelcome());

        }

        private void btnViewFrames_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAnimations_Click(object sender, EventArgs e)
        {

        }
    }
}
