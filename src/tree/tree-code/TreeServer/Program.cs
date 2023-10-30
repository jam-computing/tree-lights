using System.Net;
using System.Net.Sockets;
using TreeAPI.Config;
using TreeServer.Requests;
using WebSocketSharp.Server;

namespace TreeServer;

class Program {
    public static void Main(string[] args) {

        string ipAddr = "";

        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (IPAddress ip in host.AddressList) {
            if (ip.AddressFamily == AddressFamily.InterNetwork) {
                ipAddr = ip.ToString();
            }
        }

        ServerConfig config = ServerConfig.GetConfig();

        WebSocketServer server = new WebSocketServer(config.Port);
        Console.WriteLine("Started WebServer");
        
        #region Add services to the server

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

        server.AddWebSocketService<SetupRequest>("/SetupRequest");
        Console.WriteLine("Added Setup Request Handler");

        server.AddWebSocketService<PingRequest>("/Ping");
        Console.WriteLine("Added Ping Request");

        server.AddWebSocketService<StoredAnimationRequest>("/FrameRequest");
        Console.WriteLine("Added Frame Request");

        server.AddWebSocketService<CreateSendableFile>("/CreateFile");
        Console.WriteLine("Added Create file Request");

        server.AddWebSocketService<TestRequest>("/Test");
        Console.WriteLine("Added test request");

        #endregion

        server.Start();
        Console.WriteLine("Ready To Receive Frames");
        

        // Stop the server when the user inputs any key followed by "y"
        ConsoleColor consoleColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"This server is being hosted on ws://{ipAddr}:{config.Port}");
        Console.ForegroundColor = consoleColor;

        while (true) {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Are you sure you want to stop? ( y / N )");
            Console.ForegroundColor = consoleColor;

            switch (Console.ReadLine()) {
                case "y":
                    server.Stop();
                    break;
                default:
                    break;
            }
        }

    }
}