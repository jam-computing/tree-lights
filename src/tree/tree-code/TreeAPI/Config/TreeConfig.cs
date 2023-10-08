using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAPI.Types;

namespace TreeAPI.Config;

public class TreeConfig
{
    private static string ConfigFile { get; } = "../../../../../../../data/config.json";

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
        Address = this.IP,
        Port = this.Port,
        Path = path
    };
}