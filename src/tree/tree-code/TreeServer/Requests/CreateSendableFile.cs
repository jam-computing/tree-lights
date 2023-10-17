using TreeAPI;
using static TreeAPI.DirectoryHolder;
using TreeAPI.Types;
using WebSocketSharp;
using WebSocketSharp.Server;
namespace TreeServer.Requests;

public class CreateSendableFile : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        string json = e.Data;
        
        Console.WriteLine("Received request");


        if (!json.ToLower().Contains("animation"))
        {
            var frame = (Frame)ISendable.FromJson<Frame>(json);
            Console.WriteLine("This is a frame");
            using (StreamWriter sw = new StreamWriter(FrameDirectory + frame.Name + ".json", false))
            {
                sw.WriteLine(json);
            }
        }
        else
        {
            var animation = (Animation)ISendable.FromJson<Animation>(json);
            Console.WriteLine("This is an animation");
            using (StreamWriter sw = new StreamWriter(AnimationDirectory + animation.Name + ".json", false))
            {
                sw.WriteLine(json);
            }
        }
    }
}