using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree_Scanner;
using TreeAPI;
using TreeAPI.Types;
using TreeAPI.Config;
using WebSocketSharp;

namespace TreeGUI.Scanner
{
    public partial class formScan : Form
    {


        private string? _IP => ((TreeConfig)TreeConfig.GetConfig()).IP;
        private int _port = ((TreeConfig)TreeConfig.GetConfig()).Port;
        private List<Point> _points = new List<Point>();

        private const int numberOfLights = 10;

        public formScan()
        {
            InitializeComponent();
            lblCurrentIP.Text += "\n" + _IP;
            lblCurrentPort.Text += "\n" + _port.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            DataManger.LightPositions = _points;
            DataManger.PrintDataToFile();
            (ActiveForm as formMaster)?.DisplayForm(new formMain());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (ActiveForm as formMaster)?.DisplayForm(new formTreePhoto());
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            if (_IP is null || _port == -1)
            {
                MessageBox.Show(@"Please fill in the port and IP fields");
                return;
            }

            buttonBack.Enabled = false;
            buttonStartScan.Enabled = false;
            buttonNext.Enabled = false;

            buttonStartScan.Text = @"Working...";

            IpAddr address = new IpAddr()
            {
                Address = _IP,
                Port = _port,
                Path = "SetupRequest"
            };


            progressBar1.Step = (int)(100 / (float)numberOfLights);

            for (int i = 0; i < numberOfLights; i++)
            {
                Thread.Sleep(1000);

                ProcessedImage image = new ProcessedImage();
                pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
                pictureboxTreePhoto.Refresh();
                _points.Add(image.BrightestPoints[0]);

                progressBar1.PerformStep();
            }

            int randomNumber = new Random().Next(100,999);


            // If using address in ctor, it automatically connects
            using(Tree tree = new(address))
            {

                // Our request to begin setup

                var SetupReq = new SetupRequest() { Sender = $"TreeSetupGUI{randomNumber}" };

                tree.Send(SetupReq);

                string receivedText = tree.ReceivedMessage;

                foreach(var i in Enumerable.Range(0, numberOfLights))
                {
                    var req = new SetupRequest() { Sender = $"TreeSetupGUI{randomNumber}" };

                    tree.Send(req);

                    var msg = tree.ReceivedMessage.Split(":")[^1].Trim();

                    if (msg == $"{i}") continue;

                    MessageBox.Show("An error occured :(");

                    break;
                }

            }

            //using (Tree tree = new(address)) {
            //    tree.Connect(address);

            //    int numberOfLights = 0; // = tree.PlsGetNumberOfLights();
            //    for (int i = 0; i < numberOfLights; i++) {
            //        // await tree.TurnOnLightAtIndexAndTurnOffAllOthers(i);
            //        Thread.Sleep(1000); // To simulate above - IK i need to covert this to async

            //        ProcessedImage image = new ProcessedImage();
            //        pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
            //        _points.Add(image.BrightestPoints[0]);
            //    }
            //}

            buttonStartScan.Text = "Start Scan";
            buttonNext.Enabled = true;
            buttonBack.Enabled = true;
            buttonStartScan.Enabled = true;
        }


    }
}
