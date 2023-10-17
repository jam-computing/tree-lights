using TreeAPI.Config;
using WebSocketSharp;
using TreeAPI.Types;
using static TreeAPI.DirectoryHolder;

namespace TreeAPI;

public class Tree : IDisposable
{
    public WebSocketSharp.WebSocket? WebSocket { get; set; } = null;

    public bool? IsConnected  => this.WebSocket?.IsAlive;

    public string? ReceivedMessage { get; private set; } = null;
    public Tree() {}

    public Tree(IpAddr ip) => Connect(ip);
    
    public ReturnValue Connect(string IP, int port, string path)
    {

        if(IsConnected is true)
            WebSocket?.Close();


        Console.WriteLine("Connecting...");

        try
        {
            WebSocket = new WebSocket("ws://" + IP + ":" + port + "/" + path);
            WebSocket.OnMessage += GetMessage!;
            WebSocket.Connect();
        }
        catch (Exception)
        {
            return ReturnValue.Failure;
        }
        

        Console.WriteLine("Connected to server at: " + IP + ". at port: " + port);


        return ReturnValue.Success;
    }

    public ReturnValue Connect(IpAddr ip)
    {
        
        if(IsConnected is not null || IsConnected is true)
            WebSocket?.Close();

        Console.WriteLine("Connecting...");

        try
        {
            WebSocket = new WebSocket(ip.ToString());
            WebSocket.OnMessage += GetMessage!;
            WebSocket.Connect();

        }
        catch (Exception)
        {
            return ReturnValue.Failure;
        }

        Console.WriteLine("Connected to server at:" + ip.ToString()); 

        return ReturnValue.Success;
    }

    public ReturnValue Send(ISendable message)
    {
        if (WebSocket is null) return ReturnValue.Failure;

        try
        {
            WebSocket.Send(message.ToJson());
        }
        catch (Exception)
        {
            return ReturnValue.Failure;
        }
        
        return ReturnValue.Success;
    }

    public ReturnValue Send(string message)
    {
        if (WebSocket is null) return ReturnValue.Failure;

        try
        {
            WebSocket.Send(message);
        }
        catch (Exception)
        {
            return ReturnValue.Failure;
        }

        return ReturnValue.Success;
    }

    public void CreateFrameFile(Frame sendable)
    {
        if (IsConnected is false) return;
        Console.WriteLine("Sending Frame");

        sendable.Name += "-frame";
        
        this.Connect(ClientConfig.GetConfig().GetIpAddr("CreateFile"));
        this.Send(sendable);
    }
    
    public void CreateAnimationFile(Animation sendable)
    {
        if (IsConnected is false) return;
        Console.WriteLine("Sending Animation");

        sendable.Name += "-animation";
        
        this.Connect(ClientConfig.GetConfig().GetIpAddr("CreateFile"));
        this.Send(sendable);
    }

    private void GetMessage(object sender, MessageEventArgs e) =>
        ReceivedMessage = e.Data;

    public void Dispose()
    {
        Console.WriteLine("Connection to tree terminated ( safe )");
        WebSocket?.Close();
        WebSocket = null;
    }
}