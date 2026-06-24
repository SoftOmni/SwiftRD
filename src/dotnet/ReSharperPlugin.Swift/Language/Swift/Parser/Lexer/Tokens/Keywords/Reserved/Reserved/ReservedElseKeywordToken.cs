namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedElseKeywordToken : ReservedKeywordToken
{
    public ReservedElseKeywordToken()
        : base("#else", SwiftTokens.ReservedElseId, SwiftTokens.ReservedElseIndex)
    { }
}
