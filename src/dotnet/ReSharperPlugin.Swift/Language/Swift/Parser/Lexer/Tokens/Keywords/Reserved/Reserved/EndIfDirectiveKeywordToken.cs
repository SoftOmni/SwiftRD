namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedEndIfKeywordToken : ReservedKeywordToken
{
    public ReservedEndIfKeywordToken()
        : base("#endif", SwiftTokens.ReservedEndIfId, SwiftTokens.ReservedEndIfIndex)
    { }
}