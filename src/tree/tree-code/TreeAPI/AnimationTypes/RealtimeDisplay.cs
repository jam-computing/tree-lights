namespace TreeAPI.Types;

internal class RealtimeDisplay : DisplayType
{
    public RealtimeDisplay(Frame? frame = null)
    {
        Type = TreeDisplayType.Realtime;
        
        if (frame == null) return;

        Frame = frame;

    }
    
    public override void SendToServer()
    {
        // Code?
    }
    
    public TreeDisplayType Type { get; }
    public Frame Frame { get; } = new();
}