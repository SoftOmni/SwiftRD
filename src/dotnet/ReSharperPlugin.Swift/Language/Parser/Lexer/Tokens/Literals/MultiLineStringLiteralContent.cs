

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralContent : StringLiteralContent
{
    private readonly string _string;

    public MultiLineStringLiteralContent(string valueOfContents, string value, int indentation)
        : this(valueOfContents, value, indentation, SwiftTokens.MultiLineStringLiteralContentIndex)
    { }
    
    protected MultiLineStringLiteralContent(string valueOfContents, string value, int indentation, int index)
        : base(valueOfContents, value, index)
    {
        _string = value;
        Indentation = indentation;
    }

    public int Indentation { get; }
}