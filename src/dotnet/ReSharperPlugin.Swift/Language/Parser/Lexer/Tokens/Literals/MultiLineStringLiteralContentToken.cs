namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralContentToken : StringLiteralContentToken
{
    public MultiLineStringLiteralContentToken()
        : this(SwiftTokens.MultiLineStringLiteralContentId, SwiftTokens.MultiLineStringLiteralContentIndex)
    { }

    protected MultiLineStringLiteralContentToken(string tokenId, int index)
        : base(tokenId, index)
    { }
}

public class MultiLineStringLiteralContentBackingLiteralToken(string valueOfContents, string value, int indentation)
    : BackingStringLiteralContent(valueOfContents, value, SwiftTokens.MultiLineStringLiteralContentIndex)
{
    public int Indentation { get; } = indentation;
}