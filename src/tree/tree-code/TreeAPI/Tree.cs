using TreeAPI.Config;
using WebSocketSharp;
using TreeAPI.Types;
using static TreeAPI.DirectoryHolder;

namespace TreeAPI;

// Now this is the backbone of the entire API
// It handles connection, disconnection, sending and receiving data from the tree
public class Tree : IDisposable
{
    // The websocket object that is the connection between the server and client
    public WebSocketSharp.WebSocket? WebSocket { get; set; } = null;

    // Returns true if a connection is valid
    public bool? IsConnected  => this.WebSocket?.IsAlive;

    // This is used to store the message that COULD be received from the server
    public string? ReceivedMessage { get; private set; } = null;
    
    // Empty ctor ( That's all! )
    public Tree() {}

    // If the user gives an Addr in the ctor, just connect right away
    public Tree(IpAddr ip) => Connect(ip);
    
    public ReturnValue Connect(string IP, int port, string path)
    {
        // This will connect to the server with some specified ip details
        // Not recommended to use this, instead use the IpAddr object
        
        if(IsConnected is not null or true)
            WebSocket?.Close();

        Console.WriteLine("Connecting...");

        try
        {
            // Start the connection with the details provided
            WebSocket = new WebSocket("ws://" + IP + ":" + port + "/" + path);
            // Make sure to capture the message
            WebSocket.OnMessage += GetMessage!;
            // Actually connect!
            WebSocket.Connect();
        }
        catch (Exception)
        {
            return ReturnValue.Failure;
        }
        
        // Print some stuff to console
        Console.WriteLine("Connected to server at: " + IP + ". at port: " + port);

        return ReturnValue.Success;
    }

    public ReturnValue Connect(IpAddr ip)
    {
        // If there is already a connection, close it down
        if(IsConnected is not null or true)
            WebSocket?.Close();

        Console.WriteLine("Connecting...");

        // Could crash! ( wrap it in a try fr )
        try
        {
            // Create the websocket with the ip provided
            WebSocket = new WebSocket(ip.ToString());
            // Make sure to capture the message when received
            WebSocket.OnMessage += GetMessage!;
            // Connect!
            WebSocket.Connect();

        }
        catch (Exception)
        {
            return ReturnValue.Failure;
        }

        // Print out some debug info
        Console.WriteLine("Connected to server at:" + ip.ToString()); 

        return ReturnValue.Success;
    }

    public ReturnValue Send(ISendable message)
    {
        // Message can be anything that implements ISendable
        if (WebSocket is null) return ReturnValue.Failure;

        try
        {
            // Send the data as a JSON string
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
        // Similar to the method above, but just send a string, commonly used with endpoints, Text and Ping
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
        // This will tell the server to create a Frame file ( json ) on the server disk from the specified object
        if (IsConnected is false) return;
        Console.WriteLine("Sending Frame");

        sendable.Name += "-frame";
        
        this.Connect("CreateFile".GetIp());
        this.Send(sendable);
    }
    
    public void CreateAnimationFile(Animation sendable)
    {
        // This will tell the server to create a Animation file ( json ) on the server disk from the specified object
        if (IsConnected is false) return;
        Console.WriteLine("Sending Animation");

        sendable.Name += "-animation";
        
        this.Connect("CreateFile".GetIp());
        this.Send(sendable);
    }

    // Stored the message in a variable ready to be accessed by the client
    // This will only run when a message is received 
    // So easy to check for null if no message is received
    private void GetMessage(object sender, MessageEventArgs e) =>
        ReceivedMessage = e.Data;

    // This is allows the statement to be used in a "using"
    public void Dispose()
    {
        Console.WriteLine("Connection to tree terminated ( safe )");
        // Close the socket safely
        WebSocket?.Close();
        WebSocket = null;
    }
}