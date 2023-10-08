using TreeAPI.Types;
using WebSocketSharp.Server;
using WebSocketSharp;
using Newtonsoft.Json;
using rpi_ws281x;
using System.Drawing;

namespace TreeServer.Requests;

internal class SetupRequest : WebSocketBehavior
{
    public int CurrentIndex { get; private set; } = -1;
    private const string logsDir = "../../../../../../../data/logs/";
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = (TreeAPI.Setup)ISendable.FromJson<TreeAPI.Setup>(e.Data);
        Console.WriteLine("REQUEST TO SETUP - FROM " + data.Sender);

        // Means a setup request
        if(data.index == -1)
        {
            DataHolder.KnownSenders.Add(data.Sender);
            Send("Setup Request Received - Continue");
            OutputToFile(data.Sender, $"{data.Sender} has begun setup of christmas tree.");
            return;
        }

        CurrentIndex = data.index;

        // Turn corresponding light on
       
        var settings = Settings.CreateDefaultSettings();
        var controller = settings.AddController(data.ledCount);

        using(var rpi = new WS281x(settings)) {
            rpi.Reset();
            controller.SetLED(data.index, Color.White);
        }


        Send($"Turned on: {CurrentIndex}");
        OutputToFile(data.Sender + "-Setup", $"{data.Sender} has requested light of index: {data.index}");
    }

    private void OutputToFile(string sender, string data)
    {
        // output to the logs directory

        string file = $"{logsDir}{sender}-Setup";

        if (!File.Exists(file)) File.Create(file);

        using(var sw = new StreamWriter(file, append: true))
        {
            sw.WriteLine(data);
        }

    }
}
