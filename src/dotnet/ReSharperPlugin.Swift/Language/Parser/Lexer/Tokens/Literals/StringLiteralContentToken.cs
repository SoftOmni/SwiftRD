using String = ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes.String;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralContentToken : SwiftLiteral
{
    public StringLiteralContentToken() : this(SwiftTokens.StringLiteralContentId, SwiftTokens.StringLiteralContentIndex)
    { }
    
    protected StringLiteralContentToken(string tokenId, int index)
        : base(tokenId, index)
    { }

    public override bool IsStringLiteral => true;

    public override string TokenRepresentation => SwiftTokens.StringLiteralContentId;
}

public class BackingStringLiteralContent : TokenLiteralBacker<String, string>
{
    public BackingStringLiteralContent(string valueOfContents, string value)
        : this(valueOfContents, value, SwiftTokens.StringLiteralContentIndex)
    { }

    protected BackingStringLiteralContent(string valueOfContents, string value, int index)
        : base(String.Instance, valueOfContents, value, index)
    { }
}