using TreeAPI;
using TreeAPI.Config;

var rng = new Random();




using (Tree tree = new Tree(ClientConfig.GetConfig().GetIpAddr("Test")))
{
    if (tree.IsConnected is false) return;

    tree.Send("red");
    
    Thread.Sleep(500);
}


    
    



