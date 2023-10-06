using TreeAPI.Types;
using TreeAPI;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class AnimationHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = ISendable.FromJson<Animation>(e.Data);
        Console.WriteLine("RECEIVED ANIMATION - " + data.Sender);
        Send("ANIMATION CONFIRMATION - FROM " + data.Sender); 
    }
}