using System.Text.Json;
namespace TreeAPI.Types;

public class Frame : ISendable
{
    
    public Frame( IEnumerable<(int, int, int)>? pixels = null, string? sender = null )
    {
        if (pixels is null || sender == null) return;

        (Sender, Pixels) = (sender, (pixels as List<(int, int, int)>)!);
    }

    public string Sender { get; init; } = String.Empty;
    public List<(int, int, int)> Pixels { get; init; } = new();
}