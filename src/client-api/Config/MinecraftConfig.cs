using Newtonsoft.Json;

namespace TreeAPI.Config;

// This is specifically for the Minecraft implementation
// To learn more, read docs/Minecraft.md

public class MinecraftConfig 
{
    // Path for config file
    // DO NOT need to check for OS because can only run on Win
    public static string ConfigFile { get; } = "../../../../../../../data/minecraft.json";

    // Returns instance of itself
    public static MinecraftConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);
                
        foreach (var line in file)
            configData += line;
                
        return JsonConvert.DeserializeObject<MinecraftConfig>(configData)!;
    }
    
    // Image used ( the tree )
    // Functionality missing for requesting from the server to actually access the image
    public string? MinecraftImage { get; set; }
    // X and Y coords of the chosen image
    public int ImageX { get; set; }
    public int ImageY { get; set; }
}