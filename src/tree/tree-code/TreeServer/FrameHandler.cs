using Newtonsoft.Json;
using TreeAPI.Types;
using TreeAPI;
using System.Net.WebSockets;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

class FrameHandler : WebSocketBehavior
{
    public FrameHandler()
    {
        
    }
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = ISendable.FromJson<Frame>(e.Data);
        Console.WriteLine("RECEIVED FRAME - " + data.Sender);
        Send("FRAME CONFIRMATION - FROM " + data.Sender);

        PrintFrame(data! as Frame);
        
    }

    private void PrintFrame(Frame data)
    {
        int index = 0;
        foreach (var i in data.Pixels)
        {
            Console.WriteLine($"{++index}: ({i.Item1} {i.Item2} {i.Item3})");
        }
    }
}