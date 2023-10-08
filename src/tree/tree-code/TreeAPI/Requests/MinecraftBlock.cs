using TreeAPI.Types;

namespace TreeAPI.Requests;

public class MinecraftBlock : ISendable
{
    public string Sender { get; init; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int ValueOne { get; set; } = -1;
    public int ValueTwo { get; set; } = -1;
}