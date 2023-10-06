using Newtonsoft.Json;
using System.Text.Json;
namespace TreeAPI.Types;

public interface ISendable
{
    public string Sender { get; init; }
    public string ToJson() =>
        JsonConvert.SerializeObject(this);

    public static ISendable FromJson<T>(string data) where T : ISendable =>
        JsonConvert.DeserializeObject<T>(data)!;
}