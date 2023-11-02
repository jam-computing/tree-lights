using TreeAPI.Types;

namespace TreeAPI;

// One of the cornerstone types that make up the API
public class Animation : ISendable
{
    public Animation(List<Frame>? frames = null, string? sender = null)
    {
        if (sender == null || frames == null) return;

        (Sender, Frames) = (sender, frames);
    }

    // Indexer just returns the frame
    public Frame this[int i] => Frames[i];
    // Who is sending the data, Not as important in this than in other types
    public string Sender { get; init; } = String.Empty;
    // The actual frames that the animation is based on
    public List<Frame> Frames { get; set; } = new();
    // A bool as to if it should loop or not
    // Defaults to true because looping is cool
    public bool IsLooping { get; set; } = true;
    // The name of the animation
    // Give it a cool name!
    // Primarily used to store on disk and access again
    // Make it descriptive!
    public string Name { get; set; }
}