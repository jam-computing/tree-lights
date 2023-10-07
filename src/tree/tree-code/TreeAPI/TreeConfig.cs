using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAPI;

public class TreeConfig
{
    public string? IP { get; set; }
    public int Port { get; set; }


    public string MinecraftImage { get; set; }
    public int ImageX { get; set; }
    public int ImageY { get; set; }

    public static TreeConfig GetConfig()
    {
        string configFile = "../../../../../../../data/config.json";

        string configData = "";
        string[] file = File.ReadAllLines(configFile);

        foreach (var line in file)
            configData += line;

        return JsonConvert.DeserializeObject<TreeConfig>(configData)!;

    }
}
