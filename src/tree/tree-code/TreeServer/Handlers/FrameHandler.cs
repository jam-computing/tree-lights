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
        Send("Frame received - from TreeServer" );
        
        DataHolder.Sendables.Add(data);
    }

}