using TreeAPI.Types;

namespace TreeAPI;

public class Setup : ISendable
{
    public string Sender { get; init; } = String.Empty;

    // -1 means a setup request, else turn the corresponding light on
    public int index { get; init; } = -1;

    public int ledCount { get; init; } = 0;
}
