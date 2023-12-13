using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class BlockRequest : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("REQUEST FOR BLOCKS - ANONYMOUS");
        foreach (var block in DataHolder.MinecraftBlocksReceived)
        {
            Console.WriteLine($"{block.Name} : ( {block.ValueOne}, {block.ValueTwo} )");
        }
        Send(JsonConvert.SerializeObject(DataHolder.MinecraftBlocksReceived));
        Console.WriteLine("SENT BLOCKS TO ANONYMOUS");
    }
}