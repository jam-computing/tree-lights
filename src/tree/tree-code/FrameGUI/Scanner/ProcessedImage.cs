using Emgu.CV;
using Emgu.CV.Structure;

namespace Tree_Scanner; 
internal class ProcessedImage {

    private static readonly VideoCapture _camera = new();
    public Mat Picture { get; private set; } = new();
    public Image<Bgr, Byte> RawImage { get; private set; }
    public Image<Gray, Byte> GrayscaleImage { get; private set; }
    public Image<Gray, Byte> BlurredImage { get; private set; }

    public Point[] BrightestPoints {
        get {
            BlurredImage.MinMax(out _, out _, out _, out Point[] maxValues);
            return maxValues;
        }
    }

    public Bitmap RawImageBitmap {
        get {
            return RawImage.ToBitmap();
        }
    }

    public Bitmap HighlightBrightestPoints {
        get {
            Image<Bgr, Byte> highlighted = RawImage.Clone();
            foreach (var point in BrightestPoints) {
                highlighted.Draw(new CircleF(point, 10), new Bgr(0, 225, 0), -1);
            }
            return highlighted.ToBitmap();
        }
    }

    public ProcessedImage() {
        _camera.Read(Picture);
        RawImage = Picture.ToImage<Bgr, Byte>();
        GrayscaleImage = RawImage.Convert<Gray, Byte>();
        BlurredImage =  GrayscaleImage.SmoothGaussian(101);
    }
}