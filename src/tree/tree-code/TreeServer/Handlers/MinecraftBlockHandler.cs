using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class MinecraftBlockHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = e.Data;
        var Blocks = JsonConvert.DeserializeObject<List<MinecraftBlock>>(data)!;
        Console.WriteLine("RECEIVED BLOCK - Anonymous");
        DataHolder.MinecraftBlocksReceived.AddRange(Blocks);

        foreach (var block in DataHolder.MinecraftBlocksReceived)
        {
            Console.WriteLine($"{block.Name} : ( {block.ValueOne}, {block.ValueTwo} )");
        }
        
        Send("Block received - from TreeServer"); 
    }
}