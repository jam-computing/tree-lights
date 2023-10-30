using TreeGUI;

namespace Tree_Scanner;
// Really simple, just greet the user
public partial class formWelcome : Form
{
    public formWelcome()
    {
        InitializeComponent();
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        // Open the TOS page
        (ActiveForm as formMaster)?.DisplayForm(new formInfo());
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        // Go back to main
        (ActiveForm as formMaster)?.DisplayForm(new formHome());
    }

    private void formWelcome_Load(object sender, EventArgs e)
    {

    }
}
