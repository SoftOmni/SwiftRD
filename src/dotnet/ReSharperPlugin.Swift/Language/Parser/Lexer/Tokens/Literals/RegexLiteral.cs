using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class RegexLiteral()
    : SwiftLiteral(SwiftTokens.RegularExpressionLiteralId, SwiftTokens.RegularExpressionLiteralIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.RegularExpressionLiteralId;
    
    public override bool IsConstantLiteral => true;
}

public class RegexBackingLiteralToken(RegularExpression valueOfContents, string value)
    : TokenLiteralBacker<Regex, RegularExpression>(Regex.Instance, valueOfContents, value, SwiftTokens.FalseIndex)
{
    public const string Keyword = "false";
}