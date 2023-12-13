using System.Transactions;
using static Newtonsoft.Json.JsonConvert;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace TreeServer.Requests
{
    internal class LedLocationRequest : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Send(SerializeObject(Tree.Current));
        }
    }
}
