using WebSocketSharp;

using TreeAPI.Types;

namespace TreeAPI;

public class Tree : IDisposable
{
    public WebSocketSharp.WebSocket? WebSocket { get; set; } = null;
    
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
        
        Console.WriteLine($"Send message : \"{message}\".");
        return ReturnValue.Success;
    }


    private void GetMessage(object sender, MessageEventArgs e)
    {
        Console.WriteLine(e.Data);
    }

    public void Dispose()
    {
        Console.WriteLine("Closing stuff down");
        WebSocket?.Close();
        WebSocket = null;
    }
}