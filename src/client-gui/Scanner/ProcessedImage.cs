using Emgu.CV;
using Emgu.CV.Structure;

namespace Tree_Scanner; 
// This class represents a ProcessedImage
// Has methods to Process a raw image into what we need
internal class ProcessedImage {

    // Use the camera
    private static readonly VideoCapture _camera = new();
    // The actual picture
    public Mat Picture { get; set; } = new();
    // A raw image which has full access to the BRG colour spectrum
    public Image<Bgr, Byte> RawImage { get; set; }
    // The grayscale image which needs to then be blurred
    public Image<Gray, Byte> GrayscaleImage { get; set; }
    // The final blurred image
    public Image<Gray, Byte> BlurredImage { get; set; }
    

    // Brightest points is just an array of points in a Image
    public Point[] BrightestPoints {
        // Actually blur the image in here!
        // ( don't ask me how )
        get {
            BlurredImage.MinMax(out _, out _, out _, out Point[] maxValues);
            return maxValues;
        }
    }

    // Set the width and height equal to that of the raw image.
    public int Width { get => RawImage.Width; }
    public int Height { get => RawImage.Height; }
    
    

    // Highlight the brightest point(s)
    public static Image<Bgr, Byte> HighlightPoints(Image<Bgr, Byte> image, Point[] points) {
        
        // Create a highlighted image
        Image<Bgr, Byte> highlighted = image.Clone();
        // Foreach point in the image, draw a circle to represent the brightest point
        foreach (var point in points) {
            highlighted.Draw(new CircleF(point, 10), new Bgr(0, 225, 0), -1);
        }
        // Return the highlighted image to the caller
        return highlighted;        
    }
    

    // Why is ctor down here?
    public ProcessedImage() {
        // Get the picture from the camera
        _camera.Read(Picture);
        // convert it to a RawImage
        RawImage = Picture.ToImage<Bgr, Byte>();
        // Greyscale it
        GrayscaleImage = RawImage.Convert<Gray, Byte>();
        // Blue it
        BlurredImage =  GrayscaleImage.SmoothGaussian(101);
    }
}