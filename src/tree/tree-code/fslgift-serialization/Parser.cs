using static FslGift.TokenType;

using TreeAPI;
using TreeAPI.Types;

using System.Drawing;

namespace FslGift;
internal class Parser
{
    // Holds the current index of the Token List
    private static int _current;
    private static List<Token> _tokens = new();

    internal static void Parse(List<Token> tokens, int FrameCount, int LedCount, ref Animation Original)
    {
        // Reset vals
        _current = 0;
        _tokens = tokens;

        // Index of the current " frame " ( really just a set of x Leds ( LedCount ))
        int currentFrame = 0;

        // Way easier to create a list of tuples and then transform into animation than trying to just do animation right away
        List<(int, int, int)> pixels = new();

        foreach (var token in _tokens)
        {
            switch (Current().Type)
            {
                case NUMBER:
                    if (Previous().Type == LEFT_BRACKET) // Must be a R value
                    {
                        pixels.Add(new());
                        pixels[currentFrame] = new(Convert.ToInt16(Current().Data), 0, 0);
                    }
                    else if (Previous().Type == NUMBER && Peek().Type == NUMBER) // Must be a G value
                    {
                        pixels[currentFrame] = new(pixels[currentFrame].Item1, Convert.ToInt16(Current().Data), pixels[currentFrame].Item3);
                    }
                    else // Must be a B value
                    {
                        pixels[currentFrame] = new(pixels[currentFrame].Item1, pixels[currentFrame].Item2, Convert.ToInt16(Current().Data));
                        currentFrame++;
                    }
                    break;
                default: break;
            }
            // Next token
            Next();
        }

        // Frames is just a list of list of tuples
        // Each frame holds a size of LedCount
        List<List<(int, int, int)>> frames = new();

        for (int i = 0; i < pixels.Count; i += LedCount)
        {
            var list = pixels.GetRange(i, Math.Min(LedCount, pixels.Count - i));
            frames.Add(list);
        }

        // This will not work
        // var frames = Enumerable.Range(0, FrameCount).Select(x => pixels.Where(y => y.Item1 == x).ToList()).ToList();


        // Go through frames and turn them all into actual Frame Objects within the Animation object
        Original.Frames = Enumerable.Range(0, FrameCount - 1).Select(x => new Frame(
           Enumerable.Range(0, LedCount - 1).Select(y => Color.FromArgb(0, frames[x][y].Item1, frames[x][y].Item2, frames[x][y].Item3)).ToList()
           )).ToList();

    }


    static void Next() => _current++;
    static Token Peek() => _tokens[_current < _tokens.Count ? _current + 1 : _current];
    static Token Current() => _tokens[_current];
    static Token Previous() => _tokens[_current > 0 ? _current - 1 : _current];
}
