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

        int randomNumber = new Random().Next(100, 999);

        // If using address in ctor, it automatically connects
        using (Tree tree = new(address))
        {
            // Our request to begin setup

            var SetupReq = new Setup() { Sender = $"TreeSetupGUI{randomNumber}" };

            tree.Send(SetupReq);

            string receivedText = tree.ReceivedMessage!;

            foreach (var i in Enumerable.Range(0, numberOfLights))
            {
                var req = new Setup() { Sender = $"TreeSetupGUI{randomNumber}", index = i, LedCount = numberOfLights };

                tree.Send(req);

                var msg = tree.ReceivedMessage!.Split(":")[^1].Trim();

                if (msg != $"{i}") { MessageBox.Show("An error occured :("); break; }

                ProcessedImage image = new ProcessedImage();
                pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
                pictureboxTreePhoto.Refresh();
                _points.Add(image.BrightestPoints[0]);

                progressBar1.PerformStep();
            }
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
