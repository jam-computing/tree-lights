using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeAPI;
using TreeAPI.Types;
using Newtonsoft.Json;
using TreeAPI.Config;

namespace TreeGUI
{
    public partial class ViewMinecraftImage : Form
    {
        public ViewMinecraftImage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // LOAD
        private void button1_Click(object sender, EventArgs e)
        {
            var img = GetImage();
            if (img is null) return;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (ActiveForm as formMaster)!.Size = new Size(500, 300);
            (ActiveForm as formMaster)!.DisplayForm(new formMain());
        }

        private Bitmap? GetImage()
        {
            label1.Text = "Connecting...";

            var minecraft = MinecraftConfig.GetConfig() as MinecraftConfig;
            var config = TreeConfig.GetConfig() as TreeConfig;
            

            var file = "../../../../../../../data/images/" + minecraft!.MinecraftImage;

            if (!File.Exists(file)) return null;

            Image image = Image.FromFile(file);

            if (config!.IP is null)
            {
                label1.Text = @"No IP found in config.json";
                return (Bitmap)image;
            }

            IpAddr IP = new IpAddr() { Address = config.IP!, Port = config.Port, Path = "BlockRequest" };

            List<MinecraftBlock> Blocks = new();

            using (var tree = new Tree(IP))
            {
                if (!tree.IsConnected)
                {
                    tree.Dispose();
                    label1.Text = @"No connection";
                    return (Bitmap)image;
                }
                tree.Send("Hello from MinecraftImageHandler");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(tree.ReceivedMessage);

                if (tree.ReceivedMessage is "[]") { label1.Text = @"No Minecraft Blocks available"; return (Bitmap)image; }

                Blocks = JsonConvert.DeserializeObject<List<MinecraftBlock>>(tree.ReceivedMessage!)!;
            }

            int imageX = minecraft!.ImageX;
            int imageY = minecraft!.ImageY;
            

            int factor = (int)Math.Round(Convert.ToDouble(image.Height / imageX));

            label1.Text += factor;
                
            Bitmap bitmap = (Bitmap)image;

            if (Blocks is null) return bitmap;

            List<(int, int)> locations = Enumerable.Range(0, Blocks.Count).Select(x => (Blocks[x].ValueOne, Blocks[x].ValueTwo)).ToList();

            foreach (var (width, height) in locations)
            {
                var newWidth = Math.Abs(width) * factor;
                var newHeight = Math.Abs(height)  * factor;

                for (var i = newWidth - factor > 0 ? newWidth - factor : newWidth;
                     i < (newWidth + factor < bitmap.Width ? newWidth + factor : newWidth);
                     i++)
                {

                    for (var j = newHeight - factor > 0 ? newHeight - ( factor - 2 ) : newHeight;
                         j < (newHeight + ( factor + 2 ) < bitmap.Height ? newHeight + factor : newHeight);
                         j++)
                    {
                        bitmap.SetPixel(i, j, Color.Blue);
                    }
                }
            }

            return bitmap;
        }

    }
}
