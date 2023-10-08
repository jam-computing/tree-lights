using Newtonsoft.Json;

namespace TreeAPI.Config;

public class MinecraftConfig 
{
    public static string ConfigFile { get; } = "../../../../../../../data/minecraft.json";

    public static MinecraftConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);
                
        foreach (var line in file)
            configData += line;
                
        return JsonConvert.DeserializeObject<MinecraftConfig>(configData)!;
    }
    
    public string? MinecraftImage { get; set; }
    public int ImageX { get; set; }
    public int ImageY { get; set; }
}