using Tree_Scanner;
using TreeAPI.Config;
using TreeAPI.Types;
using TreeAPI;
using TreeAPI.Config;

namespace TreeGUI {
    public partial class formHome : Form {
        public static Tree Tree { get; set; } = new Tree();
        public static bool HasEstablishedConnection { get; set; } = false;



        public formHome() {
            InitializeComponent();
            Size size = WindowConfig.GetSize();
            this.Size = new Size(size.Width, size.Height);
            CheckConnection();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void CheckConnection() {

            if (HasEstablishedConnection || ClientConfig.GetConfig().Test == true) {
                SetButtons(true);
                btnConnecToTree.Text = @"Connected to Tree!";
                if (ClientConfig.GetConfig().Test == true)
                    lblInfo.Text = @"TESTING BUILD";
                return;
            }


            lblInfo.Text = @"Testing Connection...";

            IpAddr ip = ClientConfig.GetConfig().GetIpAddr("Text");

            Tree.Connect(ip);
            Tree.Send("New TreeGUI instance - Connecting to server");

            if (Tree.IsConnected == false) {
                lblInfo.Text = @"Could not connect to the Tree server. Please check your config files";
                SetButtons(false);
                return;
            }


            // dont ask
            Tree.WebSocket!.OnMessage += (sender, e) => {
                Thread.Sleep(50);
                var form = formMaster.ChildForm as formHome;
                form?.Invoke(() => {
                    string message = e.Data;
                    btnConnecToTree.Text = "Connected to Tree!";
                    HasEstablishedConnection = true;
                    SetButtons(true);
                });
            };


            lblInfo.Text = String.Empty;

        }

        // btnSetupTree
        private void button1_Click(object sender, EventArgs e) {
            var activeForm = ActiveForm as formMaster;
            // Set size to size of Scanner
            Size size = WindowConfig.GetSize();
            this.Size = new Size(size.Width, size.Height);
            // activeForm!.Size = new Size(700, 601);
            activeForm!.MaximizeBox = false;
            activeForm!.DisplayForm(new formWelcome());

        }

        private void SetButtons(bool enabled) {
            btnSendToTree.Enabled = enabled;
            btnViewMinecraft.Enabled = enabled;
            btnSetupTree.Enabled = enabled;
            btnConnecToTree.Enabled = !enabled;

        }

        private void btnViewFrames_Click(object sender, EventArgs e) {

        }


        private void btnSendToTree_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formSendToTree());

        private void formMain_Load(object sender, EventArgs e) {

        }

        private void btnViewMinecraft_Click(object sender, EventArgs e) {
            var size = WindowConfig.GetSize();
            (ActiveForm as formMaster)!.Size = new Size(size.Width, size.Height);
            (ActiveForm as formMaster)!.DisplayForm(new ViewMinecraftImage());
        }

        private void btnOpenConfig_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formSettings());

        private void btnConnecToTree_Click(object sender, EventArgs e) =>
            CheckConnection();
    }
}
