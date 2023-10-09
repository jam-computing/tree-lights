using System.Net;
using System.Net.Sockets;
using TreeServer.Requests;
using TreeAPI;
using TreeAPI.Config;
using WebSocketSharp.Server;

namespace TreeServer;

class Program
{
    public static void Main(string[] args)
    {

        string IpAddr = "";

        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                IpAddr = ip.ToString();
            }
        }

        var config = ServerConfig.GetConfig();

        

        var treeConfig = TreeConfig.GetConfig();


        Console.WriteLine("Starting WebServer");
        var server = new WebSocketServer(config.Port);

        server.AddWebSocketService<FrameHandler>("/Frame");
        Console.WriteLine("Added Frame Handler");
        
        server.AddWebSocketService<AnimationHandler>("/Animation");
        Console.WriteLine("Added Animation Handler");

        server.AddWebSocketService<TextHandler>("/Text");
        Console.WriteLine("Added Text Handler");        
        
        server.AddWebSocketService<MinecraftBlockHandler>("/MinecraftBlock");
        Console.WriteLine("Added Minecraft Block Handler");
        
        server.AddWebSocketService<BlockRequest>("/BlockRequest");
        Console.WriteLine("Added Minecraft Request Handler");

        server.AddWebSocketService<Requests.SetupRequest>("/SetupRequest");
        Console.WriteLine("Added Setup Request Handler");

        server.AddWebSocketService<PingRequest>("/Ping");
        Console.WriteLine("Added Ping Request");

        server.Start();
        Console.WriteLine("Ready To Receive Frames");

        Console.WriteLine($"This server is being hosted on ws://{IpAddr}:{config.Port}");



        while (true) {
            if (Console.ReadLine()?.ToLower() == "stop")
                break;
            else if(Console.ReadLine()?.ToLower() == "show frame") 
                DataHolder.Sendables[^1].ToFrame().PrintFrame();
            else if(Console.ReadLine()?.ToLower() == "show text")
                Console.WriteLine(DataHolder.TextsReceived[^1]);
        }

        server.Stop();
    }
}