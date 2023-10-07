using TreeAPI.Types;
using TreeAPI;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class MinecraftBlockHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        List<MinecraftBlock> data = ISendable.FromJsonList<List<MinecraftBlock>>(e.Data);
        Console.WriteLine("RECEIVED BLOCK - Anonymous");
        DataHolder.MinecraftBlocksReceived.AddRange(data);

        foreach (var block in DataHolder.MinecraftBlocksReceived)
        {
            Console.WriteLine($"{block.Name} : ( {block.ValueOne}, {block.ValueTwo} )");
        }
        
        Send("Block received - from TreeServer"); 
    }
}