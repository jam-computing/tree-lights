
namespace TreeAPI;

public static class DirectoryHolder
{
    public static string AnimationDirectory { get; } = OperatingSystem.IsWindows() ? "../../../../../../../data/animations/" : "../../../../data/animations/";
    public static string FrameDirectory { get; } = OperatingSystem.IsWindows() ? "../../../../../../../data/frames/" : "../../../../data/frames/";

}
