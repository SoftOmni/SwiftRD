using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringInterpolationStartToken() : SwiftTokenNodeType(SwiftTokens.StringInterpolationStartId,
    SwiftTokens.StringInterpolationStartIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringInterpolationStartId;
}