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
using TreeServer;

namespace Tree_Scanner
{
    public partial class formTreePhoto : Form
    {
        public formTreePhoto()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            (ActiveForm as formMaster)?.DisplayForm(this);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (ActiveForm as formMaster)?.DisplayForm(new formWelcome());
        }

        private void buttonTakePhoto_Click(object sender, EventArgs e)
        {

            buttonTakePhoto.Enabled = false;
            buttonReset.Enabled = false;
            buttonTakePhoto.Text = "Working...";


            ProcessedImage image = new ProcessedImage();


            pictureboxTreePhoto.Image = image.RawImageBitmap;


            buttonReset.Enabled = true;
            buttonTakePhoto.Text = "Take photo";

        }




        private Bitmap GetImage()
        {
            Image image = Image.FromFile("../../../../../../../data/images/nobara.jpg");

            IpAddr IP = new IpAddr() { Address = "localhost", Port = 3000, Path = "BlockRequest" };

            List<MinecraftBlock> Blocks = new();

            using (var tree = new Tree(IP))
            {
                tree.Send("Hello from FORMS");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(tree.ReceivedMessage);
                if (tree.ReceivedMessage is null) label2.Text += "No Minecraft Blocks available";
                    Blocks = JsonConvert.DeserializeObject<List<MinecraftBlock>>(tree.ReceivedMessage!)!;
            }

            Bitmap bitmap = (Bitmap)image;

            if (Blocks is null) return bitmap;

            List<(int, int)> locations = Enumerable.Range(0, Blocks.Count).Select(x => (Blocks[x].ValueOne, Blocks[x].ValueTwo)).ToList();

            foreach (var (width, height) in locations)
            {
                var newWidth = width * 14;
                var newHeight = (height * -1) * 14;

                for (var i = newWidth - 14 > 0 ? newWidth - 14 : newWidth;
                     i < (newWidth + 14 < bitmap.Width ? newWidth + 14 : newWidth);
                     i++)
                {

                    for (var j = newHeight - 14 > 0 ? newHeight - 14 : newHeight;
                         j < (newHeight + 14 < bitmap.Height ? newHeight + 14 : newHeight);
                         j++)
                    {
                        bitmap.SetPixel(i, j, Color.Blue);
                    }
                }
            }

            return bitmap;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureboxTreePhoto.Image = null;
            buttonTakePhoto.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureboxTreePhoto.Image = (Image)GetImage();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}