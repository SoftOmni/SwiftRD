using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringInterpolationEndToken()
    : SwiftTokenNodeType(SwiftTokens.StringInterpolationEndId, SwiftTokens.StringInterpolationEndIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringInterpolationEndId;
}