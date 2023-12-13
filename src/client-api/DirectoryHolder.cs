
namespace TreeAPI;

// This just holds some directory information
public static class DirectoryHolder
{
    // Needs to change dynamically based on the operating system 
    public static string AnimationDirectory { get; } = OperatingSystem.IsWindows() ? "../../../../../../../data/animations/" : "../../../../data/animations/";
    public static string FrameDirectory { get; } = OperatingSystem.IsWindows() ? "../../../../../../../data/frames/" : "../../../../data/frames/";

}
