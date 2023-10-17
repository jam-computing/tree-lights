using Newtonsoft.Json; 
using static TreeAPI.DirectoryHolder;
using System.Drawing;
using System.Net.Http.Headers;
using TreeAPI;
using TreeAPI.Config;
using TreeAPI.Types;

var rng = new Random();

Animation animation = new()
{
    Sender = "TreeGui - Instance Master",
    Frames = Enumerable.Range(0, 20).Select(
        frame => new Frame()
        {
            Pixels = Enumerable.Range(0, ClientConfig.GetConfig().LedCount)
                .Select(pixel => Color.FromArgb(12 * frame, 0, 0)).ToList()
        }
    ).ToList(),
    IsLooping = true,
    Name = "red-ascend"
};

Frame frame = new() {
    Pixels = Enumerable.Range(0, ClientConfig.GetConfig().LedCount)
        .Select(x => Color.FromArgb(254,254,254)).ToList(),
    Name = "white"
    
};

Tree tree = new Tree();
// tree.CreateFrameFile(frame);
tree.CreateAnimationFile(animation);
Thread.Sleep(100);
tree.Dispose();
