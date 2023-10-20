using System.Drawing;
using System.Text.Json;
namespace TreeAPI.Types;

// The skeleton of the entire API, kinda
public class Frame : ISendable
{
    public Frame( List<Color>? pixels = null, string? sender = null )
    {
        if (pixels is null || sender == null) return;

        (Sender, Pixels) = (sender, pixels);
    }

    public string Sender { get; init; } = String.Empty;
    // A list of System.Drawing.Color
    // The best way to code with these is to use the 
    // Color.FromArgb(0, 0, 0); 
    public List<Color> Pixels { get; init; } = new();
    // What the frame is called!
    public string Name { get; set; } = String.Empty;
}