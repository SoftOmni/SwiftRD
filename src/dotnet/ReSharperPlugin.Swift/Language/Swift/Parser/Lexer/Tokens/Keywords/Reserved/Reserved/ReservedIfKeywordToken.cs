namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedIfKeywordToken : ReservedKeywordToken
{
    public ReservedIfKeywordToken()
        : base("#if", SwiftTokens.ReservedIfId, SwiftTokens.ReservedIfIndex)
    { }
}
