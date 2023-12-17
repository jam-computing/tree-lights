using System.Drawing;
using TreeAPI.Types;
using TreeAPI;
using WebSocketSharp;
using WebSocketSharp.Server;
using static TreeAPI.DirectoryHolder;
using Newtonsoft.Json;
using rpi_ws281x;
using TreeAPI.Config;

namespace TreeServer;

public class AnimationHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {

        Animation? data = new();

        if(!e.Data.Contains("{"))
        {
            GetFrame(out List<string> fileNames);

            foreach(var file in fileNames)
            {
                if (e.Data != file) continue;

                data = JsonConvert.DeserializeObject<Animation>(File.ReadAllLines($"{AnimationDirectory}{file}.json")[0]);
                Console.WriteLine("RECEIVED ANIMATION - " + file);
            }
        }
        else
        {
            data = (Animation)ISendable.FromJson<Animation>(e.Data);
            Console.WriteLine("RECEIVED ANIMATION - " + data.Sender);
        }

        Settings? settings = Settings.CreateDefaultSettings();
        Controller controller = settings.AddController(ClientConfig.GetConfig().LedCount, Pin.Gpio18, StripType.Unknown, ControllerType.PWM0);

        var rpi = new WS281x(settings);


        // Use thread so that the main thread doesnt sleep and can still do things

        Thread animateThread = new Thread(() =>
        {
            foreach (var frame in data.Frames)
            {
                for (int i = 0; i < frame.Pixels.Count; i++)
                {
                    controller.SetLED(i, frame.Pixels[i]);
                }
                rpi?.Render();
                Thread.Sleep(ClientConfig.GetConfig().DefaultInterval);
            }
        });

        animateThread.Start();

        Console.WriteLine("Starting Animation Thread");

        DataHolder.Sendables.Add(data);
    }

    private void GetFrame(out List<string> files)
    {
        files = new();
        foreach (var file in Directory.EnumerateFiles(AnimationDirectory, "*.*", SearchOption.AllDirectories))
            files.Add(file.Split("/")[^1].Split(".")[0]);
    }


}