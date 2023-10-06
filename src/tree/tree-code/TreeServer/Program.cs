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
        
        server.Start();
        Console.WriteLine("Ready To Receive Frames");


        while (true)
            if (Console.ReadLine() == "stop".ToLower())
                break;
        
        server.Stop();

    }
}