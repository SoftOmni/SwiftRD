namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedElseIfKeywordToken : ReservedKeywordToken
{
    public ReservedElseIfKeywordToken()
        : base("#elseif", SwiftTokens.ReservedElseIfId, SwiftTokens.ReservedElseIfIndex)
    { }
}