using TreeAPI;
using TreeAPI.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TreeGUI;
using TreeGUI.Scanner;
using Emgu.CV;

namespace Tree_Scanner
{
    public partial class formTreePhoto : Form
    {
        public List<Point> Points { get; private set; } = new List<Point>();
        private ProcessedImage? image;
        public formTreePhoto()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            DataManger.TreeCorners = Points;
            (ActiveForm as formMaster)?.DisplayForm(new formScan());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (ActiveForm as formMaster)?.DisplayForm(new formInfo());
        }

        private void buttonTakePhoto_Click(object sender, EventArgs e)
        {

            buttonTakePhoto.Enabled = false;
            buttonReset.Enabled = false;
            buttonBack.Enabled = false;
            buttonTakePhoto.Text = "Working...";


            image = new ProcessedImage();


            pictureboxTreePhoto.Image = image.RawImage.ToBitmap();


            buttonReset.Enabled = true;
            buttonBack.Enabled = true;
            buttonTakePhoto.Text = "Take photo";

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonNext.Enabled = false;
            pictureboxTreePhoto.Image = null;
            buttonTakePhoto.Enabled = true;
            Points = new List<Point>();
        }


        private void pictureboxTreePhoto_Click(object sender, EventArgs e)
        {
            if (pictureboxTreePhoto.Image is null || image is null)
            {
                return;
            }

            MouseEventArgs me = (MouseEventArgs)e;

            if (Points.Count > 2)
            {
                Points.RemoveAt(0);
            }

            Points.Add(new Point((int)(((float)me.X / 650f) * (float)image.Width), (int)(((float)me.Y / 650f) * (float)image.Height)));

            pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, Points.ToArray()).ToBitmap();

            if (Points.Count == 3)
            {
                buttonNext.Enabled = true;
            }
            else
            {
                buttonNext.Enabled = false;
            }
        }



    }
}