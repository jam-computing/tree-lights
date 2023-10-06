namespace TreeAPI.Types;

public struct IpAddr
{
    public string Address { get; set; }
    public int Port { get; set; } 
    public string Path { get; set; }

    public override string ToString() =>
        $"ws://{Address}:{Port}/{Path}";
}