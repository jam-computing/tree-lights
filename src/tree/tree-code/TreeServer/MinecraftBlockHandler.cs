using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer;

public class MinecraftBlockHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = e.Data;
        var Block = JsonConvert.DeserializeObject<MinecraftBlock>(data)!;
        Console.WriteLine("RECEIVED BLOCK - Type of: " + Block.Name + " - Anonymous ");
        DataHolder.MinecraftBlocksReceived.Add(Block);
        Send("Block received - from TreeServer"); 
    }
}