using Newtonsoft.Json; 
namespace TreeAPI.Config;

public class ServerConfig
{
    public static string ConfigFile { get; } = "../../../../../../../data/server.json";

    public static ServerConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);

        foreach (var line in file)
            configData += line;

        return JsonConvert.DeserializeObject<ServerConfig>(configData)!;
    }

    public int Port { get; set; } 
    public List<string> Endpoints { get; set; } = new();


}
