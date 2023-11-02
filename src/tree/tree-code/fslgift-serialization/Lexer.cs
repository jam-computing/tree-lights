using static fslgift_serialization.TokenType;
namespace fslgift_serialization;

internal class Lexer
{
    internal static List<Token> Lex(string str)
    {
        _current = 0;
        _tokens = new();

        for (; _current < str.Length;)
        {
            switch (Current(str))
            {
                case '[':
                    Consume(new Token(LEFT_BRACKET, null)); break;
                case ']':
                    Consume(new Token(RIGHT_BRACKET, null)); break;
                case ',':
                    Next(); break;

                default:
                    {
                        // if its not a number idfk what is going on
                        if (!Char.IsNumber(Current(str))) continue;

                        string num = String.Empty;

                        num += Current(str);

                        // Loop until the number is over
                        while (Char.IsNumber(Peek(str)))
                        {
                            _current++;
                            num += Current(str);
                        }
                        Consume(new Token(NUMBER, num));

                        break;
                    }
            }
        }

        return _tokens;
    }

    private static int _current;
    private static List<Token> _tokens = new();

    // Increment current without consuming token
    static void Next() => _current++;
    // Consume token and increment  
    static void Consume(Token token)
    {
        _tokens.Add(token);
        _current++;
    }
    // Look at the next token
    static char Peek(string str) => str[_current + 1];
    // Look at the current token
    static char Current(string str) => str[_current];
    // Look at the previous token 
    static char Previous(string str) => str[_current - 1];
}
