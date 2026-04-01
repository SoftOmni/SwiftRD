namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class RegularExpressionLiteralToken() : SwiftLiteral(SwiftTokens.RegularExpressionLiteralId, SwiftTokens.RegularExpressionLiteralIndex)
{
    public override string TokenRepresentation => SwiftTokens.RegularExpressionLiteralId;
}