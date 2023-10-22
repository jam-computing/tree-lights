using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGUI;

namespace Tree_Scanner
{
    public partial class formInfo : Form
    {
        public formInfo()
        {
            InitializeComponent();
            var str = "";
            // Set the terms and agreements text to whatever
            Enumerable.Range(0, 1000).Select(x => "Emacs sucks, ").ToList().ForEach(x => str += x);
            richTextBox2.Text = str;        
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Open the actual photo form
            (ActiveForm as formMaster)?.DisplayForm(new formTreePhoto());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Go back to the welcome screen
            (ActiveForm as formMaster)?.DisplayForm(new formWelcome());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Simple if to check 
            if (radioButton1.Checked)
            {
                buttonNext.Enabled = true;
                return;
            }
            // Else, the button isn't checked so button should be off
            buttonNext.Enabled = false;
        }
    }
}
