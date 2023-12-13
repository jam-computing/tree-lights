using System.Drawing;
using TreeAPI.Types;

namespace TreeServer;

internal class Tree : ISendable
{
    public static Tree Current { get; set; } = new();
    public string Name { get; set; } = String.Empty;
    public List<Color> LEDs { get; set; } = new();
    public string Sender { get; init; } = String.Empty;
}
