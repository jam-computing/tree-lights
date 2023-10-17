using System.Drawing;
using System.Text.Json;
namespace TreeAPI.Types;

public class Frame : ISendable
{
    
    public Frame( List<Color>? pixels = null, string? sender = null )
    {
        if (pixels is null || sender == null) return;

        (Sender, Pixels) = (sender, pixels);
    }

    public string Sender { get; init; } = String.Empty;
    public List<Color> Pixels { get; init; } = new();
    public string Name { get; set; } = String.Empty;
}