namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedImageLiteralKeywordToken : ReservedKeywordToken
{
    public ReservedImageLiteralKeywordToken()
        : base("#imageLiteral", SwiftTokens.ReservedImageLiteralId, SwiftTokens.ReservedImageLiteralIndex)
    { }
}