using System.Drawing;
using Newtonsoft.Json;
namespace TreeAPI.Config;

public class WindowConfig
{
    public static string ConfigFile { get; } = "../../../../../../../data/window.json";

    public int windowX { get; set; }
    public int windowY { get; set; }

    public static WindowConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);

        foreach (var line in file)
            configData += line;
        return JsonConvert.DeserializeObject<WindowConfig>(configData)!;
    }

    public static Size GetSize()
    {
        var conf = GetConfig();
        return new Size(conf.windowX, conf.windowY);
    }
}
