using Newtonsoft.Json;

namespace TreeAPI.Types;

public interface ISendable
{
    public string Sender { get; init; }
    public string ToJson() =>
        JsonConvert.SerializeObject(this);

    public static List<MinecraftBlock> FromJsonList<T>(string data) where T : IEnumerable<MinecraftBlock> =>
        JsonConvert.DeserializeObject<T>(data)!.ToList();

    public static ISendable FromJson<T>(string data) where T : ISendable =>
        JsonConvert.DeserializeObject<T>(data)!;
}