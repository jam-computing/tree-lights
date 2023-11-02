using static fslgift_serialization.TokenType;
using TreeAPI;
using TreeAPI.Types;
using System.Drawing;
namespace fslgift_serialization;

internal class Parser
{
    private static int _current;
    private static List<Token> _tokens = new();
    internal static Animation Parse(List<Token> tokens, int FrameCount, int LedCount, Animation Original)
    {
        _current = 0;
        _tokens = tokens;

        int currentFrame = 0;

        List<(int, int, int)> pixels = new();

        foreach (var token in _tokens)
        {
            switch (Current().Type)
            {
                case NUMBER:
                    if (Previous().Type == LEFT_BRACKET) // R
                    {
                        pixels.Add(new());
                        pixels[currentFrame] = new(Convert.ToInt16(Current().Data), 0, 0);
                    }
                    else if (Previous().Type == NUMBER && Peek().Type == NUMBER) // G
                    {
                        pixels[currentFrame] = new(pixels[currentFrame].Item1, Convert.ToInt16(Current().Data), pixels[currentFrame].Item3);
                    }
                    else
                    { // B
                        pixels[currentFrame] = new(pixels[currentFrame].Item1, pixels[currentFrame].Item2, Convert.ToInt16(Current().Data));
                        currentFrame++;
                    }
                    break;
                default: break;
            }

            Next();
        }

        var frames = Enumerable.Range(0, FrameCount).Select(x => pixels.Where(y => y.Item1 == x).ToList()).ToList();

        Animation animation = new Animation()
        {
            Frames = Enumerable.Range(0, FrameCount - 1).Select(x => new Frame(
               Enumerable.Range(0, LedCount - 1).Select(y => Color.FromArgb(0, frames[x][y].Item1, frames[x][y].Item2, frames[x][y].Item3)).ToList()
               )).ToList(),
            Sender = Original.Sender,
            IsLooping = Original.IsLooping,
            Name = Original.Name
        };

        return animation;
    }


    static void Next() => _current++;
    static Token Peek() => _tokens[_current < _tokens.Count ? _current + 1 : _current];
    static Token Current() => _tokens[_current];
    static Token Previous() => _tokens[_current > 0 ? _current - 1 : _current];
}
