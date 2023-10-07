using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeGUI
{
    public partial class formMaster : Form
    {
        public Form? ChildForm { get; set; }
        public Panel MasterPanel => panelMaster;
        public formMaster()
        {
            InitializeComponent();
            DisplayForm(new formMain());
        }

        public void DisplayForm(Form form)
        {
            ChildForm = form;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.BringToFront();

            panelMaster.Controls.Clear();
            panelMaster.Controls.Add(ChildForm);
            ChildForm.Show();

        }
    }
}
