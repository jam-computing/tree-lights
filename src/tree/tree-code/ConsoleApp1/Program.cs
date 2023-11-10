using TreeAPI;
using FslGift;
using TreeAPI.Types;
using System.Drawing;
/*
Animation test = new()
{
    Frames = Enumerable.Range(0, 1000).Select(x => new Frame()
    {
        Pixels = Enumerable.Range(0, 500).Select(y => Color.FromArgb(0, x / 10, x / 20, y / 2)).ToList()
    }).ToList(),
    Sender = "Matthew",
    Name = "ReallyCoolAnimation"
};

string str = GiftConvert.SerializeAnimation(test);


using (StreamWriter sw = new("Example.fslgift"))
{
    sw.Write(str);
}
*/
string[] file = File.ReadAllLines("Example.fslgift");

var animation = GiftConvert.DeserializeAnimation(file);

Console.WriteLine(animation.Sender);
