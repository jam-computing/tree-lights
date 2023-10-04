using TreeAPI;
namespace TreeAPI.Types;

internal class AnimationDisplay : DisplayType
{
       public AnimationDisplay()
       {
           Type = TreeDisplayType.Animation;
       }
       
       public override void SendToServer()
       {
              // Server must be open
       }

       public TreeDisplayType Type { get; }
       
       public List<Frame> Frames { get; set; }
}