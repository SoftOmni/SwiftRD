namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedUnavailableKeywordToken : ReservedKeywordToken
{
    public ReservedUnavailableKeywordToken()
        : base("#unavailable", SwiftTokens.ReservedUnavailableId, SwiftTokens.ReservedUnavailableIndex)
    { }
}