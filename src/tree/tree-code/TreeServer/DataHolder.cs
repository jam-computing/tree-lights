using TreeAPI;
using TreeAPI.Types;
using TreeAPI.Requests;

namespace TreeServer;

public static class DataHolder {
    public static List<ISendable> Sendables { get; set; } = new();
    public static List<string> TextReceived { get; set; } = new();
    public static List<MinecraftBlock> MinecraftBlocksReceived { get; set; } = new();
    public static List<string> KnownSenders { get; set; } = new();

    public static Frame ToFrame(this ISendable sendable) {
        if (sendable is Frame) return (sendable as Frame)!;
        return (sendable as Animation)!.Frames[^1];
    }
}