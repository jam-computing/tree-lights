using Newtonsoft.Json;
using TreeAPI.Types;

namespace TreeAPI.Config;

/*
 * Maps to "data/client.json"
 */

public class ClientConfig
{
    // MUST check if OS is windows before setting path
    // Dotnet core on linux has it's path from the folder containing your .cs files, windows does NOT

    public static string ConfigFile { get; } = OperatingSystem.IsWindows() ? "../../../../../../../data/client.json" : "../../../../data/client.json";

    // All fields in the json
    public string? IP { get; set; }
    public int Port { get; set; }
    public bool Test { get; set; }
    public int LedCount { get; set; }
    public int DefaultInterval { get; set; }

    // Returns an instance of ClientConfig, with all the data from the json
    public static ClientConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);

        foreach (var line in file)
            configData += line;

        return JsonConvert.DeserializeObject<ClientConfig>(configData)!;
    }

    // Easy IpAddr grabber from the json

    public IpAddr GetIpAddr(string path) => new()
    {
        Address = IP!,
        Port = Port,
        Path = path
    };
}