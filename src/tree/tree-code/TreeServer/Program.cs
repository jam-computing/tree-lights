using TreeAPI;
using WebSocketSharp.Server;

namespace TreeServer;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Starting WebServer");
        //var server = new WebSocketServer(3000);
        
        //server.AddWebSocketService<TreeSocket>("/TreeSocket");
        //server.Start();
        //Console.ReadKey(true);
        //server.Stop();

        using(Tree tree = new Tree()) {
            tree.Connect("10.56.253.51", 3000, "Animation");
            
            tree.Send("Josh sucks");
        }

    }
}