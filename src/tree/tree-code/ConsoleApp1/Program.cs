using System.Drawing;
using TreeAPI;
using TreeAPI.Types;
using FslGift;


Animation ani = new()
{
    Frames = Enumerable.Range(0, 100).Select(x => new Frame(Enumerable.Range(0, 500)
        .Select(y => Color.FromArgb(x, y / 2, 0)).ToList())).ToList(),
    IsLooping = true,
    Name = "Special Animation",
    Sender = "Jules"
};

var str = GiftConvert.SerializeAnimation(ani);

using (StreamWriter sw = new StreamWriter("Test.fslgift"))
{
    sw.WriteLine(str);
}

var str1 = File.ReadAllLines("Test.fslgift");

Animation animation = GiftConvert.DeserializeAnimation(str1);

Console.WriteLine(animation.Sender);