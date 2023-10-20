namespace TreeAPI.Types;

// Struct represents an Ip Address
public struct IpAddr
{
    public IpAddr(string address, int port, string path)
    {
        Address = address;
        Port = port;
        Path = path;
    }
    
    // The actual IPv4 address of the server.
    // This will be shown by the server when booting up
    public string Address { get; set; }
    // Specified port to run on
    // This is defaulted to 1234 and should never really be changed
    // UNLESS you could have multiple different servers? idk why you would do that tbh
    public int Port { get; set; } 
    // What endpoint are you trying to reach?
    // Look at docs/Endpoints.md
    public string Path { get; set; }

    public override string ToString() =>
        $"ws://{Address}:{Port}/{Path}";
}