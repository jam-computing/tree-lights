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


namespace TreeGUI.Scanner {
    public partial class formScan : Form {

        private string? _IP = null;
        private int _port = -1;
        private List<Point> _points = new List<Point>();

        public formScan() {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            DataManger.LightPositions = _points;
            DataManger.PrintDataToFile();
            (ActiveForm as formMaster)?.DisplayForm(new formMain());
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(new formTreePhoto());
        }

        private void buttonStartScan_Click(object sender, EventArgs e) {
            if (_IP is null || _port == -1) {
                MessageBox.Show("Please fill in the port and IP fields");
                return;
            }

            buttonBack.Enabled = false;
            buttonStartScan.Enabled = false;
            buttonNext.Enabled = false;

            buttonStartScan.Text = "Working...";

            IpAddr address = new IpAddr();
            address.Address = _IP;
            address.Port = _port;
            address.Path = ""; // What goes here ?????

            int numberOfLights = 10;

            progressBar1.Step = (int)(100 / (float)numberOfLights);

            for (int i = 0; i < numberOfLights; i++) {
                Thread.Sleep(1000);

                ProcessedImage image = new ProcessedImage();
                pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, image.BrightestPoints).ToBitmap();
                pictureboxTreePhoto.Refresh();
                _points.Add(image.BrightestPoints[0]);

                progressBar1.PerformStep();
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

        private void tbIP_TextChanged(object sender, EventArgs e) {
            _IP = tbIP.Text;
        }

        private void tbPort_TextChanged(object sender, EventArgs e) {
            bool success = int.TryParse(tbPort.Text, out _port);
            if (!success) {
                MessageBox.Show("Ensure the port is a number");
                tbPort.Text = string.Empty;
                return;
            }
        }
    }
}
