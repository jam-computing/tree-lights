using TreeAPI.Config;
using TreeAPI;
using TreeAPI.Types;
using System.Drawing;
namespace ConsoleApp1;

public class FrameSendTester
{
    public Animation CreateAnimation()
    {
        
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

        return animation;
    }

    public Frame CreateFrame()
    {

        Frame frame = new() {
            Pixels = Enumerable.Range(0, ClientConfig.GetConfig().LedCount)
                .Select(x => Color.FromArgb(254,254,254)).ToList(),
            Name = "white"
    
        };
        
        return frame;
    }
}