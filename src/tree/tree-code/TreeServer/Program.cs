using TreeAPI;
using WebSocketSharp.Server;

namespace TreeServer;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting WebServer");
        var server = new WebSocketServer(3000);
<<<<<<< HEAD

        server.AddWebSocketService<TreeSocket>("/TreeSocket");
=======
        
        server.AddWebSocketService<FrameHandler>("/Frame");
        Console.WriteLine("Added Frame Handler");
        
        server.AddWebSocketService<AnimationHandler>("/Animation");
        Console.WriteLine("Added Animation Handler");
        
>>>>>>> f195eeaddf470fe6fcf65add280887e201ab9306
        server.Start();
        Console.WriteLine("Ready To Receive Frames");


        while (true)
            if (Console.ReadLine() == "stop".ToLower())
                break;
        
        server.Stop();
    }
}