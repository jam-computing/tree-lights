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
                
                Console.WriteLine("RECEIVED FRAME - " + file);
            }
        }
        else
        {
            data = (Frame)ISendable.FromJson<Frame>(e.Data);
            Console.WriteLine("RECEIVED FRAME - " + data.Sender);
        }

        RaspberryPi.RPi?.Reset();

        for(int i = 0; i < RaspberryPi.LedCount; i++) {
            RaspberryPi.Controller.SetLED(i, data.Pixels[i]);
        }

        RaspberryPi.RPi?.Render();

        DataHolder.Sendables.Add(data);
    }

    private void GetFrame(out List<string> files)
    {
        files = new();
        foreach (var file in Directory.EnumerateFiles(FrameDirectory, "*.*", SearchOption.AllDirectories))
            files.Add(file.Split("/")[^1].Split(".")[0]);
    }

}