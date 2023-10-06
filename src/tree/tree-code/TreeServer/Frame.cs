using System.Net.WebSockets;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

class Frame : WebSocketBehavior
{
    public Frame()
    {
        
    }
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("FRAME");
        Send("just recevied a frame - server");
    }
}