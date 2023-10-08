using Newtonsoft.Json;
using TreeAPI.Types;

namespace TreeAPI.Config;

public class TreeConfig
{
    public static string ConfigFile { get; } = "../../../../../../../data/config.json";

    public static TreeConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);
                
        foreach (var line in file)
            configData += line;
                
        return JsonConvert.DeserializeObject<TreeConfig>(configData)!;
    }
    public string? IP { get; set; }
    public int Port { get; set; }

    public IpAddr GetIpAddr(string path) => new() {
        Address = IP!,
        Port = Port,
        Path = path
    };
}