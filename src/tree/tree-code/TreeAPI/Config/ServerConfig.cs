using Newtonsoft.Json; 
namespace TreeAPI.Config;

public class ServerConfig
{
    
    // The server should only really be run a linux / rpi but for debugging still check OS
    public static string ConfigFile { get; } = OperatingSystem.IsWindows() ? "../../../../../../../data/server.json" : "../../../../data/server.json";

    // Like the others, return instance of itself
    public static ServerConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);

        foreach (var line in file)
            configData += line;

        return JsonConvert.DeserializeObject<ServerConfig>(configData)!;
    }

    // Just grab the port and optional endpoints
    // Not sure why you wouldn't want all of them but who knows?
    public int Port { get; set; } 
    public List<string> Endpoints { get; set; } = new();


}
