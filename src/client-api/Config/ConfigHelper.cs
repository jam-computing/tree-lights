using TreeAPI.Types;

namespace TreeAPI.Config;

public static class ConfigHelper
{
    public static IpAddr GetIp(this string path) =>
        ClientConfig.GetConfig().GetIpAddr(path);

}