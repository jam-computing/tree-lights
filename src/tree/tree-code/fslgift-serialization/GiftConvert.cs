using System.Drawing.Drawing2D;
using fslgift_serialization;
using TreeAPI;
namespace FslGift;

public class GiftConvert
{
    public static string SerializeAnimation(Animation animation)
    {
        string gift = String.Empty;

        gift += $"Sender: \"{animation.Sender}\"\n";
        gift += $"Name: \"{animation.Name}\"\n";
        gift += $"Interval: \"unspecifed\"\n";
        gift += $"IsLooping: \"{animation.IsLooping}\"\n";
        gift += $"LedCount: \"{animation.Frames[0].Pixels.Count}\"\n";
        gift += $"FrameCount: \"{animation.Frames.Count}\"\n\n";

        gift += "---\n\n";

        var index = 1;

        foreach (var frame in animation.Frames)
        {

            gift += $"{index++}: ";
            foreach (var pixel in frame.Pixels)
            {
                gift += $"[{pixel.R},{pixel.G},{pixel.B}],";
            }

            gift += "\n";

        }

        return gift;
    }

    public static Animation DeserializeAnimation(string[] str)
    {
        Animation animation = new()
        {
            Sender = str[0].Split("\"")[1],
            Name = str[1].Split("\"")[1],
            IsLooping = Convert.ToBoolean(str[3].Split("\"")[1])
        };
        int index = 0;

        // Find end of properties and start of data
        while (true)
        {
            if (str[index].Contains('-'))
            {
                index += 2;
                break;
            }
            index++;
        }


        // List of tokens to parse
        List<Token> tokens = new();

        // Primary loop
        do
        {
            string data = str[index].Split(":")[1].Trim();

            tokens.AddRange(Lexer.Lex(data));

            index++;
        }

        // Repeat while there isnt a number at the start of the line
        while (int.TryParse(str[index].Split(":")[0], out int res));

        // Dynamically update
        return Parser.Parse(tokens, Convert.ToInt16(str[5].Split("\"")[1]), Convert.ToInt16(str[4].Split("\"")[1]), animation);
    }

}