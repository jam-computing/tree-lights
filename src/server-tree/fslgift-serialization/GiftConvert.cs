using TreeAPI;
using System.Text;
namespace FslGift;

public static class GiftConvert
{
    public static string SerializeAnimation(Animation animation)
    {

        StringBuilder stringBuilder = new();

        stringBuilder.Append($"Sender: \"{animation.Sender}\"\n");
        stringBuilder.Append($"Name: \"{animation.Name}\"\n");
        stringBuilder.Append($"Interval: \"unspecified\"\n");
        stringBuilder.Append($"IsLooping: \"{animation.IsLooping}\"\n");
        stringBuilder.Append($"LedCount: \"{animation.Frames[0].Pixels.Count}\"\n");
        stringBuilder.Append($"FrameCount: \"{animation.Frames.Count}\"\n\n");

        stringBuilder.Append("---\n\n");

        var index = 1;

        foreach (var frame in animation.Frames)
        {

            stringBuilder.Append($"{index++}: ");
            foreach (var pixel in frame.Pixels)
            {
                stringBuilder.Append($"[{pixel.R},{pixel.G},{pixel.B}],");
            }

            stringBuilder.Append($"\n");

        }

        stringBuilder.AppendLine();

        return stringBuilder.ToString();
    }

    public static Animation DeserializeAnimation(params string[] str)
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

        // Repeat while there isn't a number at the start of the line
        while (int.TryParse(str[index].Split(":")[0], out int _));

        // Dynamically update
        Parser.Parse(tokens, Convert.ToInt16(str[5].Split("\"")[1]), Convert.ToInt16(str[4].Split("\"")[1]), ref animation);

        return animation;
    }

}