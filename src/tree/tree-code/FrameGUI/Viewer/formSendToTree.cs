using System.Configuration.Internal;
using Newtonsoft.Json;
using TreeAPI;
using TreeAPI.Config;
using static TreeAPI.DirectoryHolder;

namespace TreeGUI
{
    public partial class formSendToTree : Form
    {

        private ClientConfig config => ClientConfig.GetConfig();
        private List<string> AllSendables = new();
        public formSendToTree()
        {


            InitializeComponent();

            Tree tree = formMain.Tree;

            tree.Connect(config.GetIpAddr("FrameRequest"));
            tree.Send("animation");

            Thread.Sleep(200);

            List<string> animationFileNames = JsonConvert.DeserializeObject<List<string>>(tree.ReceivedMessage!)!;

            comboBox1.Items.AddRange(animationFileNames.ToArray());

            tree.Connect(config.GetIpAddr("FrameRequest"));
            tree.Send("frame");

            Thread.Sleep(200);

            List<string> frameFileNames = JsonConvert.DeserializeObject<List<string>>(tree.ReceivedMessage!)!;

            comboFrameList.Items.AddRange(frameFileNames.ToArray());

        }



        private void btnBack_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formMain());

        private void btnSend_Click(object sender, EventArgs e)
        {
            Tree tree = formMain.Tree;
            tree.Connect(ClientConfig.GetConfig().GetIpAddr("Text"));

            tree.Send(txtBoxSend.Text);

        }

        private void btnSendFrame_Click(object sender, EventArgs e)
        {
            Tree tree = formMain.Tree;
            tree.Connect(config.GetIpAddr("Frame"));
            Console.WriteLine(comboFrameList.Text);
            tree.Send(comboFrameList.Text);

        }

        private void btnSendAnimation_Click(object sender, EventArgs e)
        {
            Tree tree = formMain.Tree;
            tree.Connect(config.GetIpAddr("Animation"));
            Console.WriteLine(comboBox1.Text);
            tree.Send(comboBox1.Text);
        }
    }
}