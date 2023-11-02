namespace FslGift;

internal class Token
{
    public Token(TokenType type, object? data)
    {
        Type = type;
        Data = data;
    }

    public TokenType Type { get; set; }
    public object? Data { get; set; }
}

internal enum TokenType
{
    RIGHT_BRACKET,
    LEFT_BRACKET,
    NUMBER
}
