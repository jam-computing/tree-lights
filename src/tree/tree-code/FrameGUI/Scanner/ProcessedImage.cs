using Emgu.CV;
using Emgu.CV.Structure;
using System.Reflection.Metadata.Ecma335;

namespace Tree_Scanner; 
internal class ProcessedImage {

    private static readonly VideoCapture _camera = new();
    public Mat Picture { get; set; } = new();
    public Image<Bgr, Byte> RawImage { get; set; }
    public Image<Gray, Byte> GrayscaleImage { get; set; }
    public Image<Gray, Byte> BlurredImage { get; set; }

    public Point[] BrightestPoints {
        get {
            BlurredImage.MinMax(out _, out _, out _, out Point[] maxValues);
            return maxValues;
        }
    }

    public int Width { get => RawImage.Width; }
    public int Height { get => RawImage.Height; }

    public static Image<Bgr, Byte> HighlightPoints(Image<Bgr, Byte> image, Point[] points) {
        
        Image<Bgr, Byte> highlighted = image.Clone();
        foreach (var point in points) {
            highlighted.Draw(new CircleF(point, 10), new Bgr(0, 225, 0), -1);
        }
        return highlighted;        
    }

    public ProcessedImage() {
        _camera.Read(Picture);
        RawImage = Picture.ToImage<Bgr, Byte>();
        GrayscaleImage = RawImage.Convert<Gray, Byte>();
        BlurredImage =  GrayscaleImage.SmoothGaussian(101);
    }
}