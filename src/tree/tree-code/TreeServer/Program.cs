using TreeAPI;
using WebSocketSharp.Server;

namespace TreeServer;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Starting WebServer");
        var server = new WebSocketServer(3000);
        
        server.AddWebSocketService<Frame>("/Frame");
        server.AddWebSocketService<Animation>("/Animation");
        server.Start();
        Console.ReadKey(true);
        server.Stop();

    }
}