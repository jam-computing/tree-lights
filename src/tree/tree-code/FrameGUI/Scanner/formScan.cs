using Emgu.CV;
using Tree_Scanner;
using TreeAPI;
using TreeAPI.Types;
using TreeAPI.Config;

namespace TreeGUI.Scanner; 
public partial class formScan : Form {


    private string? _IP => ClientConfig.GetConfig().IP;
    private int _port = ClientConfig.GetConfig().Port;
    private List<Point> _points = new List<Point>();

    private const int numberOfLights = 10;

    public formScan() {
        InitializeComponent();
        lblCurrentIP.Text += "\n" + _IP;
        lblCurrentPort.Text += "\n" + _port.ToString();
    }

    private void buttonNext_Click(object sender, EventArgs e) {
        DataManger.LightPositions = _points;
        DataManger.PrintDataToFile();
        (ActiveForm as formMaster)?.DisplayForm(new formMain());
    }

    private void buttonBack_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formTreePhoto());
    }

    private async void buttonStartScan_Click(object sender, EventArgs e) {

        if (_IP is null || _port == -1) {
            MessageBox.Show(@"Please ensure the tree config is set up properly");
            return;
        }

        progressBar1.Value = 0;
        buttonBack.Enabled = false;
        buttonStartScan.Enabled = false;
        buttonNext.Enabled = false;

        buttonStartScan.Text = @"Working...";

        IpAddr address = new IpAddr() {
            Address = _IP,
            Port = _port,
            Path = "SetupRequest"
        };

        progressBar1.Step = (int)(100 / (float)numberOfLights);

        for (int i = 0; i < numberOfLights; i++) {
            // Simulating connection delay
            await Task.Delay(1000);

            ProcessedImage image = new ProcessedImage();
            pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
            pictureboxTreePhoto.Refresh();
            _points.Add(image.BrightestPoints[0]);

            progressBar1.PerformStep();
        }


        // To avoid errors
        if (ClientConfig.GetConfig().Test == true)
            goto _L1;

        #region Connect to tree

        // Generate random numbers for username in server
        int randomNumber = new Random().Next(100, 999);

        // get tree
        var tree = formMain.Tree;
        
        // Connect to ip address
        tree.Connect(address);

        if (tree.IsConnected is false) return;

        // Create a request to begin the setup process
        var SetupReq = new Setup() { Sender = $"TreeSetupGUI{randomNumber}" };

        // Send the req
        tree.Send(SetupReq);

        // Loop through range of lights
        foreach (var i in Enumerable.Range(0, numberOfLights))
        {
            // Create a new setup request WITHOUT INDEX OF -1
            var req = new Setup() { Sender = $"TreeSetupGUI{randomNumber}", index = i, LedCount = numberOfLights };

            // Send req
            tree.Send(req);

            // store the received message from the tree in variable
            var msg = tree.ReceivedMessage!.Split(":")[^1].Trim();

            // If message number is not the right one, throw error
            if (msg != $"{i}") { MessageBox.Show("An error occured :("); break; }

            // Create the image
            ProcessedImage image = new ProcessedImage();
            pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
            pictureboxTreePhoto.Refresh();
            _points.Add(image.BrightestPoints[0]);

            // Add to the progress bar
            progressBar1.PerformStep();
        }

        #endregion

        _L1:

        progressBar1.Value = 100;
        buttonStartScan.Text = "Start Scan";
        buttonNext.Enabled = true;
        buttonBack.Enabled = true;
        buttonStartScan.Enabled = true;
    }
}