using TreeAPI.Types;
using TreeAPI;
namespace TreeGUI; 
public partial class formMaster : Form {
    public bool TreeSetup = false;
    public static Form? ChildForm { get; set; }
    public Panel MasterPanel => panelMaster;
    public formMaster() {
        InitializeComponent();
        FormClosing += Form_Close!;
        DisplayForm(new formMain());
        Size = new Size(700, 500);
        TreeSetup = true;
    }

    public void DisplayForm(Form form) {
        ChildForm = form;
        ChildForm.TopLevel = false;
        ChildForm.FormBorderStyle = FormBorderStyle.None;
        ChildForm.BringToFront();

        panelMaster.Controls.Clear();
        panelMaster.Controls.Add(ChildForm);
        ChildForm.Show();
    }

    public void Form_Close(object sender, EventArgs e)
    {
        formMain.Tree.Dispose();
    }
}
