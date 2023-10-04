namespace TreeAPI.Types;

abstract class DisplayType
{
    public abstract void SendToServer();
    public TreeDisplayType Type { get; }
}