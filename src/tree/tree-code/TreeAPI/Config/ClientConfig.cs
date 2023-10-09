﻿using Newtonsoft.Json;
using TreeAPI.Types;

namespace TreeAPI.Config;

public class ClientConfig
{
    public static string ConfigFile { get; } = "../../../../../../../data/client.json";
    
    public string? IP { get; set; }
    public int Port { get; set; }
    public bool Test { get; set; }

    public static ClientConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);
                
        foreach (var line in file)
            configData += line;
                
        return JsonConvert.DeserializeObject<ClientConfig>(configData)!;
    }

    public IpAddr GetIpAddr(string path) => new() {
        Address = IP!,
        Port = Port,
        Path = path
    };
}