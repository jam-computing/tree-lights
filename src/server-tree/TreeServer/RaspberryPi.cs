using rpi_ws281x;
using TreeAPI.Config;

namespace TreeServer;

internal static class RaspberryPi 
{
    public static Settings? Settings { get; set; } = Settings.CreateDefaultSettings();
    public static Controller Controller { get; set; }
    public static WS281x? RPi;

    public static int LedCount = ClientConfig.GetConfig().LedCount;
    public static int Interval = ClientConfig.GetConfig().DefaultInterval;

    static RaspberryPi()
    {
        Controller = Settings.AddController(LedCount, Pin.Gpio18, StripType.Unknown, ControllerType.PWM0);
        RPi = new WS281x(Settings);
    }
}
