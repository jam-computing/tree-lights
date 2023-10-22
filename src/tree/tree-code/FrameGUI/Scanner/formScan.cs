using Emgu.CV;
using Tree_Scanner;
using TreeAPI;
using TreeAPI.Types;
using TreeAPI.Config;

namespace TreeGUI.Scanner;
public partial class formScan : Form
{


    // Get configuration stuff
    private string? _IP => ClientConfig.GetConfig().IP;
    private int _port = ClientConfig.GetConfig().Port;
    private List<Point> _points = new List<Point>();

    private const int numberOfLights = 50;

    public formScan()
    {
        // Print out the IP and Port to the screen
        InitializeComponent();
        lblCurrentIP.Text += "\n" + _IP;
        lblCurrentPort.Text += "\n" + _port.ToString();
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        // Get the light positions
        DataManger.LightPositions = _points;
        // Shove it out to a file somewhere
        DataManger.PrintDataToFile();
        // Go back to the main menu
        (ActiveForm as formMaster)?.DisplayForm(new formMain());
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        // Just go back
        // easy!
        (ActiveForm as formMaster)?.DisplayForm(new formTreePhoto());
    }

    private async void buttonStartScan_Click(object sender, EventArgs e)
    {

        // if ip stuff isn't working.
        // You should be in this menu if server isn't alive but just a precautionary measure
        if (_IP is null || _port == -1)
        {
            MessageBox.Show(@"Please ensure the tree config is set up properly");
            return;
        }

        // Set progress bar to 0
        // and set defaults
        progressBar1.Value = 0;
        buttonBack.Enabled = false;
        buttonStartScan.Enabled = false;
        buttonNext.Enabled = false;

        buttonStartScan.Text = @"Working...";

        // Get the ip addr
        IpAddr address = "SetupRequest".GetIp();

        progressBar1.Step = (int)(100 / (float)numberOfLights);

        // Generate random numbers for username in server
        int randomNumber = new Random().Next(100, 999);

        // get tree
        var tree = formMain.Tree;

        // Connect to ip address
        tree.Connect(address);

        if (tree.IsConnected is false) return;

        MessageBox.Show("Connected");

        // Create a request to begin the setup process
        var SetupReq = new Setup() { Sender = $"TreeSetupGUI{randomNumber}", index = -1 };

        // Send the req
        tree.Send(SetupReq);

        // Loop through range of lights
        for (int i = 0; i < numberOfLights; i++)
        {

            // Create a new setup request WITHOUT INDEX OF -1
            Console.WriteLine("Sending number: " + i);
            var req = new Setup() { Sender = $"TreeSetupGUI{randomNumber}", index = i, LedCount = numberOfLights };

            // Send req
            tree.Send(req);

            Thread.Sleep(200);

            int index;

            // If message number is not the right one, throw error
            if (!Int32.TryParse(tree.ReceivedMessage, out index)) { MessageBox.Show("An error occured :("); break; }

            label2.Text = tree.ReceivedMessage;

            // Create a new Processed image
            ProcessedImage image = new ProcessedImage();
            // Highlight the brightest points from the image
            pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
            // Refresh the photo box
            pictureboxTreePhoto.Refresh();
            // Add the brightest point
            _points.Add(image.BrightestPoints[0]);

            // Add to the progress bar
            progressBar1.PerformStep();
        }



        // Make sure progress bar is full
        // Allow user to press buttons
        progressBar1.Value = 100;
        buttonStartScan.Text = @"Start Scan";
        buttonNext.Enabled = true;
        buttonBack.Enabled = true;
        buttonStartScan.Enabled = true;
        
    }
}