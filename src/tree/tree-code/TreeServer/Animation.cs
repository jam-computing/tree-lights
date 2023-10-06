using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class Animation : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("ANIAMTION");
        Console.WriteLine(e.Data);
        Send("I received the animation: " + e.Data);
    }
}