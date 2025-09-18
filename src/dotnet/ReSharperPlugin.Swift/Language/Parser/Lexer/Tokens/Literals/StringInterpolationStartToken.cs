using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringInterpolationStartToken() : SwiftTokenNodeType(SwiftTokens.StringInterpolationStartId,
    SwiftTokens.StringInterpolationStartIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringInterpolationStartId;
}