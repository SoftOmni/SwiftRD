namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedSourceLocationKeywordToken : ReservedKeywordToken
{
    public ReservedSourceLocationKeywordToken()
        : base("#sourceLocation", SwiftTokens.ReservedSourceLocationId, SwiftTokens.ReservedSourceLocationIndex)
    { }
}