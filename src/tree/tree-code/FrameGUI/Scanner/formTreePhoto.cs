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

        #region Minecraft?

        // Commented out till needed later ????
        //private Bitmap GetImage()
        //{
        //    label2.Text = "Connecting...";
        //    Image image = Image.FromFile("../../../../../../../data/images/nobara.jpg");

        //    IpAddr IP = new IpAddr() { Address = "localhost", Port = 3000, Path = "BlockRequest" };

        //    List<MinecraftBlock> Blocks = new();

        //    using (var tree = new Tree(IP))
        //    {
        //        if (!tree.IsConnected)
        //        {
        //            tree.Dispose();
        //            label2.Text = "No connection";
        //            return (Bitmap)image;
        //        }
        //        tree.Send("Hello from FORMS");
        //        System.Threading.Thread.Sleep(500);
        //        Console.WriteLine(tree.ReceivedMessage);

        //        if (tree.ReceivedMessage is "[]") { label2.Text = "No Minecraft Blocks available"; return (Bitmap)image; }

        //        Blocks = JsonConvert.DeserializeObject<List<MinecraftBlock>>(tree.ReceivedMessage!)!;
        //    }

        //    Bitmap bitmap = (Bitmap)image;

        //    if (Blocks is null) return bitmap;

        //    List<(int, int)> locations = Enumerable.Range(0, Blocks.Count).Select(x => (Blocks[x].ValueOne, Blocks[x].ValueTwo)).ToList();

        //    foreach (var (width, height) in locations)
        //    {
        //        var newWidth = width * 14;
        //        var newHeight = (height * -1) * 14;

        //        for (var i = newWidth - 14 > 0 ? newWidth - 14 : newWidth;
        //             i < (newWidth + 14 < bitmap.Width ? newWidth + 14 : newWidth);
        //             i++)
        //        {

        //            for (var j = newHeight - 14 > 0 ? newHeight - 14 : newHeight;
        //                 j < (newHeight + 14 < bitmap.Height ? newHeight + 14 : newHeight);
        //                 j++)
        //            {
        //                bitmap.SetPixel(i, j, Color.Blue);
        //            }
        //        }
        //    }

        //    return bitmap;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception("Minecraft??");
            // pictureboxTreePhoto.Image = (Image)GetImage();
        }

        #endregion
    }
}