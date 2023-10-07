using TreeAPI.Types;

namespace TreeAPI.Types;

public class MinecraftBlock : ISendable
{
    public string Sender { get; init; } = String.Empty;
    public string Name { get; set; } = String.Empty;
    public int ValueOne { get; set; } = -1;
    public int ValueTwo { get; set; } = -1;
}