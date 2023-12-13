using TreeAPI.Config;
using rpi_ws281x;
using Newtonsoft.Json;
using TreeAPI.Types;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Drawing;
using TreeAPI;
using static TreeAPI.DirectoryHolder;

namespace TreeServer;

class FrameHandler : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {

        Frame? data = new(); 

        // must be file path string
        if(!e.Data.Contains("{")) {

            GetFrame(out List<string> fileNames);

            foreach(var file in fileNames)
            {
                if (e.Data != file.Split("\\")[^1]) continue;

                data = JsonConvert.DeserializeObject<Frame>(File.ReadAllLines($"{FrameDirectory}{file}.json")[0]);

                data.Pixels.ForEach(x => Console.Write($"[{x.R},{x.B},{x.B}], "));
                Console.WriteLine();
                
                Console.WriteLine("RECEIVED FRAME - " + file);
            }
        }
        else
        {
            data = (Frame)ISendable.FromJson<Frame>(e.Data);
            Console.WriteLine("RECEIVED FRAME - " + data.Sender);
        }


        Settings? settings = Settings.CreateDefaultSettings();
        Controller controller = settings.AddController(ClientConfig.GetConfig().LedCount, Pin.Gpio18, StripType.Unknown, ControllerType.PWM0);

        var rpi = new WS281x(settings);

        rpi?.Reset();

        for(int i = 0; i < ClientConfig.GetConfig().LedCount; i++) {
            controller.SetLED(i, data.Pixels[i]);
        }

        rpi?.Render();

        DataHolder.Sendables.Add(data);
    }

    private void GetFrame(out List<string> files)
    {
        files = new();
        foreach (var file in Directory.EnumerateFiles(FrameDirectory, "*.*", SearchOption.AllDirectories))
            files.Add(file.Split("/")[^1].Split(".")[0]);
    }

}