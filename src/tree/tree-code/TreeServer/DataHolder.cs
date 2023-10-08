using TreeAPI;
using TreeAPI.Types;
using TreeAPI.Requests;

namespace TreeServer;

public static class DataHolder
{
    public static List<ISendable> Sendables { get; set; } = new();
    public static List<string> TextsReceived { get; set; } = new();
    public static List<MinecraftBlock> MinecraftBlocksReceived { get; set; } = new();
    public static List<string> KnownSenders { get; set; } = new();
    
    
    public static void PrintFrame(this Frame data)
    {
        int index = 0;
        foreach (var i in data.Pixels)
        {
            Console.WriteLine($"{++index}: ({i.Item1} {i.Item2} {i.Item3})");
        }
    }

    public static Frame ToFrame(this ISendable sendable)
    {
        if (sendable is Frame) return (sendable as Frame)!;
        return (sendable as Animation)!.Frames[^1];
    }
}