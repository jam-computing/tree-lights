using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_Scanner {
    public partial class formTreePhoto : Form {
        public formTreePhoto() {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(this);
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            (ActiveForm as formMaster)?.DisplayForm(new formWelcome());
        }

        private void buttonTakePhoto_Click(object sender, EventArgs e) {
            buttonTakePhoto.Enabled = false;
            buttonReset.Enabled = false;
            buttonTakePhoto.Text = "Working...";

            ProcessedImage image = new ProcessedImage();
            pictureboxTreePhoto.Image = image.RawImageBitmap;

            buttonReset.Enabled = true;
            buttonTakePhoto.Text = "Take photo";
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            pictureboxTreePhoto.Image = null;
            buttonTakePhoto.Enabled = true;
        }
    }
}
