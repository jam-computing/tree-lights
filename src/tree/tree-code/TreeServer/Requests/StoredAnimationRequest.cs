using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using static TreeAPI.DirectoryHolder;

namespace TreeServer.Requests;

internal class StoredAnimationRequest : WebSocketBehavior
{
    private List<string> fileNames = new();
    protected override void OnMessage(MessageEventArgs e)
    {
        if (e.Data.ToLower().Trim() == "animation")
            foreach (var file in Directory.EnumerateFiles(AnimationDirectory, "*.*", SearchOption.AllDirectories))
                fileNames.Add(file.Split("/")[^1].Split(".")[0]);
        else if (e.Data.ToLower().Trim() == "frame")
            foreach (var file in Directory.EnumerateFiles(FrameDirectory, "*.*", SearchOption.AllDirectories))
                fileNames.Add(file.Split("/")[^1].Split(".")[0]);

        var json = JsonConvert.SerializeObject(fileNames);
        Send(json);
        fileNames.Clear();
    }

}
