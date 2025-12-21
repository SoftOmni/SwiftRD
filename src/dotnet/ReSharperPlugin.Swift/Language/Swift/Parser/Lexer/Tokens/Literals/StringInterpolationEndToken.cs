using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringInterpolationEndToken()
    : SwiftTokenNodeType(SwiftTokens.StringInterpolationEndId, SwiftTokens.StringInterpolationEndIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringInterpolationEndId;
}