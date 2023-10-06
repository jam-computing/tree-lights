using System.Drawing;
using System.Threading.Channels;


Image image = Image.FromFile("../../../../../../../data/images/nobara.jpg");

Bitmap bitmap = (Bitmap)image;

Console.WriteLine(bitmap.Width);
Console.WriteLine(bitmap.Height);

var pixel = bitmap.GetPixel(1, 1);

bitmap.SetPixel(1,1, Color.White);

