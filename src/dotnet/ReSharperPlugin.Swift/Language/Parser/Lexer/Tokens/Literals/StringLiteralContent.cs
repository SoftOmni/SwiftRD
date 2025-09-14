using String = ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes.String;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralContent : SwiftLiteral<String, string>
{
    private readonly string _value;
    
    public StringLiteralContent(string valueOfContents, string value)
        : this(valueOfContents, value, SwiftTokens.StringLiteralContentIndex)
    { }

    protected StringLiteralContent(string valueOfContents, string value, int index)
        : base(String.Instance, valueOfContents, value, index)
    {
        _value = value;
    }

    public override bool IsStringLiteral => true;

    public override string TokenRepresentation => _value;
}