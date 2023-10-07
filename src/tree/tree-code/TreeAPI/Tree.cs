using WebSocketSharp;

using TreeAPI.Types;

namespace TreeAPI;

public class Tree : IDisposable
{
    public WebSocketSharp.WebSocket? WebSocket { get; set; } = null;

    public string? ReceivedMessage { get; private set; } = null;

    public Tree() {}

    public Tree(IpAddr ip) => Connect(ip);
    
    public ReturnValue Connect(string IP, int port, string path)
    {
        Console.WriteLine("Connecting...");

        try
        {
            WebSocket = new WebSocketSharp.WebSocket("ws://" + IP + ":" + port + "/" + path);

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
        Console.WriteLine("Connecting...");

        try
        {
            WebSocket = new WebSocketSharp.WebSocket(ip.ToString());
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

    private void GetMessage(object sender, MessageEventArgs e)
    {
        ReceivedMessage = e.Data;
    }

    public void Dispose()
    {
        Console.WriteLine("Closing stuff down");
        WebSocket?.Close();
        WebSocket = null;
    }
}