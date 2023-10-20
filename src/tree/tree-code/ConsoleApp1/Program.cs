using TreeAPI;
using TreeAPI.Config;

var rng = new Random();




using (Tree tree = new Tree("Text".GetIp()))
{
    if (tree.IsConnected is false) return;

    tree.Send("red");
    
    Thread.Sleep(100);
    
    Console.WriteLine($"Message is:  {tree.ReceivedMessage}");
    
}


    
    



