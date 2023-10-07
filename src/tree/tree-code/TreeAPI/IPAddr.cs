namespace TreeAPI.Types;

public struct IpAddr
{
    public IpAddr(string address, int port, string path)
    {
        Address = address;
        Port = port;
        Path = path;
    }
    public string Address { get; set; }
    public int Port { get; set; } 
    public string Path { get; set; }

    public override string ToString() =>
        $"ws://{Address}:{Port}/{Path}";
}