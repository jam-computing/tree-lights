namespace TreeAPI.Types;

public class Frame
{
    public Frame(IEnumerable<Pixel> pixels = null)
    {
        if (pixels is null) return;
        
        Pixels = (pixels as List<Pixel>)!;
    }

    public List<Pixel> Pixels { get; init; } = new();


}