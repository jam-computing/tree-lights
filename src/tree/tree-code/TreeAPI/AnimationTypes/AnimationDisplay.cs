using TreeAPI;
namespace TreeAPI.Types;


// TF is this code for?

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