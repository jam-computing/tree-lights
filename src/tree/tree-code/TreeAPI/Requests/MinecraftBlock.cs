using TreeAPI.Types;

namespace TreeAPI.Requests;

// Used in the Minecraft Client ( docs/Minecraft.md )
public class MinecraftBlock : ISendable
{
    // Who is sending the block data
    public string Sender { get; init; } = string.Empty;
    // The name of the block found 
    public string Name { get; set; } = string.Empty;
    // These should really be called X and Y but there not.
    public int ValueOne { get; set; } = -1;
    public int ValueTwo { get; set; } = -1;
}