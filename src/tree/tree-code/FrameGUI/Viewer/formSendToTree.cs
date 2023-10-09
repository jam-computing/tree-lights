using TreeAPI;
using TreeAPI.Config;
using static TreeAPI.DirectoryHolder;

namespace TreeGUI
{
    public partial class formSendToTree : Form
    {

        private Tree tree => formMain.Tree;
        private List<string> AllSendables = new();
        public formSendToTree()
        {
            var config = ClientConfig.GetConfig();

            tree.Connect(config.IP!, config.Port, "Text");

            InitializeComponent();

            if (tree.IsConnected is false)
            {
                MessageBox.Show(@"No TreeServer found. Try editing the config.json");
                (ActiveForm as formMaster)!.DisplayForm(new formMain());
                return;
            }

            GetFileNames();
        }


        private void GetFileNames()
        {
            foreach (var file in Directory.EnumerateFiles(FrameDirectory, "*.*", SearchOption.AllDirectories))
                AllSendables.Add(file.Split("/")[^1]);

            foreach (var file in Directory.EnumerateFiles(AnimationDirectory, "*.*", SearchOption.AllDirectories))
                AllSendables.Add(file.Split("/")[^1]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tree.IsConnected is true) tree.Dispose();
            (ActiveForm as formMaster)!.DisplayForm(new formMain());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Tree tree = formMain.Tree;
            tree.Connect(ClientConfig.GetConfig().GetIpAddr("Text"));

            tree.Send(txtBoxSend.Text);

        }
    }
}