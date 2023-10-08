using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer.Requests;

public class PingRequest : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Received PING request - " + e.Data );
        Send("pong");
    }
}
