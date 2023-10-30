using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class TextHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = e.Data;
        DataHolder.TextReceived.Add(data);
        Console.WriteLine($"RECEIVED TEXT - Anonymous - \"{data}\"");
        Send("Confirmation - Text received"); 
    }
}