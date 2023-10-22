using TreeGUI;
using TreeGUI.Scanner;
using Emgu.CV;

namespace Tree_Scanner;
public partial class formTreePhoto : Form {
    // List of points that the user has selected ( 3 )
    public List<Point> Points { get; private set; } = new List<Point>();
    private ProcessedImage? image; // Represents the image taken
    public formTreePhoto() {
        InitializeComponent();
    }

    private void buttonNext_Click(object sender, EventArgs e) {
        // Grab the user-created corners of the tree
        DataManger.TreeCorners = Points;
        (ActiveForm as formMaster)?.DisplayForm(new formScan());
    }

    private void buttonBack_Click(object sender, EventArgs e) {
        (ActiveForm as formMaster)?.DisplayForm(new formInfo());
    }

    private void buttonTakePhoto_Click(object sender, EventArgs e) {

        // Disable all the buttons while picture is being taken 
        buttonTakePhoto.Enabled = false;
        buttonReset.Enabled = false;
        buttonBack.Enabled = false;
        buttonTakePhoto.Text = @"Working...";


        // Create a new image and create it from the Taken Picture
        image = new ProcessedImage();
        pictureboxTreePhoto.Image = image.RawImage.ToBitmap();


        // Enable the buttons again
        buttonReset.Enabled = true;
        buttonBack.Enabled = true;
        buttonTakePhoto.Text = @"Take photo";

    }

    private void buttonReset_Click(object sender, EventArgs e) {
        // Reset everything and delete photo
        buttonNext.Enabled = false;
        pictureboxTreePhoto.Image = null;
        buttonTakePhoto.Enabled = true;
        // Make sure points is a new list
        Points = new List<Point>();
    }


    private void pictureboxTreePhoto_Click(object sender, EventArgs e) {
        if (pictureboxTreePhoto.Image is null || image is null) 
            return;

        // Capture the mouse position
        MouseEventArgs mouseEventArgs = (MouseEventArgs)e;

        // If it is bigger than 2, remove the first index
        // If user clicks 4 times, then just delete the element so it stays at 3 points
        if (Points.Count > 2) {
            Points.RemoveAt(0);
        }

        // Add the point where the user clicked to the list of points
        Points.Add(new Point((int)(((float)mouseEventArgs.X / (float)pictureboxTreePhoto.Width) * (float)image.Width), (int)(((float)mouseEventArgs.Y / (float)pictureboxTreePhoto.Height) * (float)image.Height)));

        // Highlight the points from the raw images
        // Display it on the screen
        pictureboxTreePhoto.Image = ProcessedImage.HighlightPoints(image.RawImage, Points.ToArray()).ToBitmap();

        // Only enable if the amount of points is equal to 3: The points of the tree
        if (Points.Count == 3) {
            buttonNext.Enabled = true;
            return;
        }
        // Else, just keep it false
        buttonNext.Enabled = false;
    }
}
