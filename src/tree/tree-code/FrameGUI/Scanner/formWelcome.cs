using TreeGUI;

namespace Tree_Scanner;
public partial class formWelcome : Form
{
    public formWelcome()
    {
        InitializeComponent();
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        (ActiveForm as formMaster)?.DisplayForm(new formInfo());
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        (ActiveForm as formMaster)?.DisplayForm(new formMain());
    }

    private void formWelcome_Load(object sender, EventArgs e)
    {

    }
}
