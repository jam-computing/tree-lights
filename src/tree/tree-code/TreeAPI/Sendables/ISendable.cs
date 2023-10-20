using Newtonsoft.Json;
using TreeAPI.Requests;

namespace TreeAPI.Types;

// Interface for the basic frame and animation types
public interface ISendable
{
    // Each type should have a name
    public string Name { get; set; }
    // Each type should have a sender
    public string Sender { get; init; }
    // methods for converting to and from json
    // Should probably be extension methods 
    public string ToJson() =>
        JsonConvert.SerializeObject(this);

    public static List<MinecraftBlock> FromJsonList<T>(string data) where T : IEnumerable<MinecraftBlock> =>
        JsonConvert.DeserializeObject<T>(data)!.ToList();

    public static ISendable FromJson<T>(string data) where T : ISendable =>
        JsonConvert.DeserializeObject<T>(data)!;
}