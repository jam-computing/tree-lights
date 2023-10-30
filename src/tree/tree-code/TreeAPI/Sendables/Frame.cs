using System.Drawing;
namespace TreeAPI.Types;

/// <summary>
/// A "Frame" is a list of colours, which corresponds to what colour each LED will be set to when it is displayed
/// </summary>
public class Frame : ISendable {
    public string Name { get; set; } = String.Empty;
    public string Sender { get; init; } = String.Empty;
    public List<Color> Pixels { get; init; } = new();

    public Frame() { }

    public Frame(List<Color> pixels, string sender) {
        Pixels = pixels;
        Sender = sender;
    }

    public override string ToString() {
        ColorConverter converter = new ColorConverter();
        
        return string.Join(", ", Pixels.Select(x => x.ToString()));
    }
}