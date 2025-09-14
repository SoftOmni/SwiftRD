using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class RegexLiteral(RegularExpression valueOfContents, string value)
    : SwiftLiteral<Regex, RegularExpression>(Regex.Instance, valueOfContents, value, SwiftTokens.RegularExpressionLiteralIndex)
{
    public override string TokenRepresentation { get; } = value;
    
    public override bool IsConstantLiteral => true;
}