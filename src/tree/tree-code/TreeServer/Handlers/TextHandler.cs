using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class TextHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = e.Data;
        DataHolder.TextsReceived.Add(data);
        Console.WriteLine("RECEIVED TEXT - Anonymous");
        Send("Text received - from TreeServer"); 
    }
}