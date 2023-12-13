﻿
using rpi_ws281x;
using System.Drawing;
using TreeAPI.Types;
using TreeAPI.Config;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer.Requests;
internal class TestRequest : WebSocketBehavior
{
    protected override async void OnMessage(MessageEventArgs e)
    {
        Settings? settings = Settings.CreateDefaultSettings();
        Controller controller = settings.AddController(ClientConfig.GetConfig().LedCount, Pin.Gpio18, StripType.Unknown, ControllerType.PWM0);

        var rpi = new WS281x(settings);

        switch (e.Data.ToLower())
        {
            case "red":
                await DisplayFrame(rpi, controller, Color.Red); break;
            case "green":
                await DisplayFrame(rpi, controller, Color.Green); break;
            case "blue":
                await DisplayFrame(rpi, controller, Color.Blue); break;
            case "blue-animation":
                await DisplayAnimation(rpi, controller, Color.Blue); break;
            case "green-animation":
                await DisplayAnimation(rpi, controller, Color.Green); break;
            case "red-animation":
                await DisplayAnimation(rpi, controller, Color.Red); break;
            default:
                break;
        }
    }

    private async Task DisplayFrame(WS281x rpi, Controller controller, Color color)
    {
        Console.WriteLine($"Displaying frame {color}");
        rpi.Reset();

        for (int i = 0; i < ClientConfig.GetConfig().LedCount; i++)
        {
            controller.SetLED(i, color);
        }

        await Task.Delay(100);

        rpi.Render();

        Console.WriteLine("Rendering Pixels");
    }

    private async Task DisplayAnimation(WS281x rpi, Controller controller, Color color)
    {
        Console.WriteLine($"Displaying animation {color}");

        int index = 0;

        rpi.Reset();
        foreach (var frame in Enumerable.Range(0, 100)
            .Select(frame => new Frame(Enumerable.Range(0, ClientConfig.GetConfig().LedCount)
                .Select(pixel => Color.FromArgb(color == Color.Red ? frame * 2 : 0, color == Color.Green ?
                frame * 2 : 0, color == Color.Blue ? frame * 2 : 0)).ToList())).ToList())
        {
            Console.WriteLine($"Frame index is: {++index}");
            for (int i = 0; i < frame.Pixels.Count; i++)
            {
                controller.SetLED(i, frame.Pixels[i]);
            }
            rpi.Render();
            await Task.Delay(ClientConfig.GetConfig().DefaultInterval);
        }
    }


}
