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

            // Grab the tree instance from the main form
            Tree tree = formHome.Tree;

            // Connect with a frame request
            tree.Connect(config.GetIpAddr("FrameRequest"));
            // Request all of the animations
            tree.Send("animation");

            // Wait for response
            Thread.Sleep(200);

            // Turn the response to a list 
            List<string> animationFileNames = JsonConvert.DeserializeObject<List<string>>(tree.ReceivedMessage!)!;

            // add them to the animation combo-box
            comboBox1.Items.AddRange(animationFileNames.ToArray());

            
            // Do the same but for frames
            tree.Connect(config.GetIpAddr("FrameRequest"));
            tree.Send("frame");

            // Wait for response
            Thread.Sleep(200);

            // Turn them into a list
            List<string> frameFileNames = JsonConvert.DeserializeObject<List<string>>(tree.ReceivedMessage!)!;

            // Add the list to the combo-box
            comboFrameList.Items.AddRange(frameFileNames.ToArray());

        }



        // Back to the main form we go!
        private void btnBack_Click(object sender, EventArgs e) =>
            (ActiveForm as formMaster)!.DisplayForm(new formHome());

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Send the text message found in the text-box
            Tree tree = formHome.Tree;
            // Connect to the Text endpoint, see docs/endpoints.md
            tree.Connect(ClientConfig.GetConfig().GetIpAddr("Text"));

            tree.Send(txtBoxSend.Text);
        }

        private void btnSendFrame_Click(object sender, EventArgs e)
        {
            // create the tree and send a filepath of the combo box text  
            Tree tree = formHome.Tree;
            tree.Connect(config.GetIpAddr("Frame"));
            Console.WriteLine(comboFrameList.Text);
            tree.Send(comboFrameList.Text);

        }

        private void btnSendAnimation_Click(object sender, EventArgs e)
        {
            // create the tree and send a filepath of the combo box text  
            Tree tree = formHome.Tree;
            tree.Connect(config.GetIpAddr("Animation"));
            Console.WriteLine(comboBox1.Text);
            tree.Send(comboBox1.Text);
        }
    }
}