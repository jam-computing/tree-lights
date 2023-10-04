using Tree_Scanner;
using System.Drawing;

namespace Tree_Scanner;
public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
        ProcessedImage image = new ProcessedImage();
        pictureBox1.Image = image.HighlightBrightestPoints;
        label1.Text = image.BrightestPoints[0].ToString();

    }

    private void pictureBox1_Click(object sender, EventArgs e) {

    }
}