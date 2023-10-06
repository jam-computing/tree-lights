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
    public partial class formMaster : Form {

        public Form? ChildForm {  get; set; } 

        public formMaster() {
            InitializeComponent();

            DisplayForm(new formWelcome());
        }

        public void DisplayForm(Form form) {
            ChildForm = form;

            // Setup ChildForm display settings
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.BringToFront();

            // Display ChildForm
            panelForm.Controls.Clear();
            panelForm.Controls.Add(ChildForm);
            ChildForm.Show();
        }
    }
}
