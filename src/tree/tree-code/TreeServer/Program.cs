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
        
<<<<<<< HEAD
        server.AddWebSocketService<TextHandler>("/Text");
        
=======
>>>>>>> f195eeaddf470fe6fcf65add280887e201ab9306
>>>>>>> ce0326c70b8e0c198ce67f5751f7f0b247ad8c5a
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