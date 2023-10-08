using System.Net;
using TreeAPI;
using TreeAPI.Types;

using(var tree = new Tree()) {

    IpAddr ip = new IpAddr() {
        Address = "localhost",
        Port = 3000,
        Path = "Frame"
    };

    tree.Connect(ip);

    if(!tree.IsConnected) return;

    Console.WriteLine("Connected!");


    Frame frame = new(new List<(int, int, int)>(), "Intrigued Reader");


    tree.Send(frame);


    Console.WriteLine("The Received Message is: ");
    Console.WriteLine(tree.ReceivedMessage);

    Thread.Sleep(1000);

}