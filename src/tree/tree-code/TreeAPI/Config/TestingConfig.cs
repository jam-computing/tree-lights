using Newtonsoft.Json;
namespace TreeAPI.Config;

public class TestingConfig
{
    public static string ConfigFile { get; } = "../../../../../../../data/testing.json";

    public static TestingConfig GetConfig()
    {
        string configData = "";
        string[] file = File.ReadAllLines(ConfigFile);

        foreach (var line in file)
            configData += line;

        return JsonConvert.DeserializeObject<TestingConfig>(configData)!;
    }

    public bool? test { get; set; }

}
