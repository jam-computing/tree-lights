using TreeAPI.Types;

namespace TreeAPI;

public class Animation : ISendable
{

    public Animation( List<Frame>? frames = null, string? sender = null)
    {
        if (sender == null || frames == null) return;

        (Sender, Frames) = (sender, frames);
    }
    
    public Frame this[int i] => Frames[i];
    public string Sender { get; init; } = String.Empty;
    public List<Frame> Frames { get; set; } = new();
    public bool IsLooping { get; set; } = false;
    public string Name { get; set; }
}