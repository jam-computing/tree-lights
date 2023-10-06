using TreeAPI;
using WebSocketSharp.Server;

namespace TreeServer;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting WebServer");
        var server = new WebSocketServer(3000);

        server.AddWebSocketService<FrameHandler>("/Frame");
        Console.WriteLine("Added Frame Handler");
        
        server.AddWebSocketService<AnimationHandler>("/Animation");
        Console.WriteLine("Added Animation Handler");

        server.AddWebSocketService<TextHandler>("/Text");
        Console.WriteLine("Added Text Handler");        
        
        server.AddWebSocketService<MinecraftBlockHandler>("/MinecraftBlock");
        Console.WriteLine("Added Minecraft Block Handler");

        server.Start();
        Console.WriteLine("Ready To Receive Frames");

        Console.WriteLine("Type 'stop' to stop the server.");
        Console.WriteLine("Type 'show frame' to show the most recent frame / animation");
        Console.WriteLine("Type 'show text' to show the most recent text");


        while (true)
            if (Console.ReadLine()?.ToLower() == "stop")
                break;
            else if(Console.ReadLine()?.ToLower() == "show frame") 
                DataHolder.Sendables[^1].ToFrame().PrintFrame();
            else if(Console.ReadLine()?.ToLower() == "show text")
                Console.WriteLine(DataHolder.TextsReceived[^1]);
        
        server.Stop();
    }
}