using TreeAPI.Types;
using WebSocketSharp.Server;
using WebSocketSharp;
using rpi_ws281x;
using System.Drawing;

namespace TreeServer.Requests;

internal class SetupRequest : WebSocketBehavior
{
    // CurrentIndex of -1 denotes a setup request
    public int CurrentIndex { get; private set; } = -1;
    private const string logsDir = "../../../../../../../data/logs/";
    protected override void OnMessage(MessageEventArgs e)
    {
        var data = (TreeAPI.Setup)ISendable.FromJson<TreeAPI.Setup>(e.Data);

        // Means a setup request
        if (data.index == -1)
        {
            DataHolder.KnownSenders.Add(data.Sender);
            // OutputToFile(data.Sender, $"{data.Sender} has begun setup of christmas tree.");
            return;
        }
        
        CurrentIndex = data.index;
        Send(CurrentIndex.ToString());


        Console.WriteLine("REQUEST TO TURN LED ON - FROM " + data.Sender);

        Console.WriteLine($"The Current LED turned on it {CurrentIndex}");


        // Turn corresponding light on

        goto L2;
       
        var settings = Settings.CreateDefaultSettings();
        var controller = settings.AddController(data.LedCount);
        


        using(var rpi = new WS281x(settings)) {
            rpi.Reset();
            controller.SetLED(data.index, Color.White);
        }


        Send($"Turned on: {CurrentIndex}");
        OutputToFile(data.Sender + "-Setup", $"{data.Sender} has requested light of index: {data.index}");

    L2:
    return;

    }

    private void OutputToFile(string sender, string data)
    {
        // output to the logs directory

        string file = $"{logsDir}{sender}-Setup.txt";

        if (!File.Exists(file)) File.Create(file);

        using(var sw = new StreamWriter(file, append: true))
        {
            sw.WriteLine(data);
        }

    }
}
