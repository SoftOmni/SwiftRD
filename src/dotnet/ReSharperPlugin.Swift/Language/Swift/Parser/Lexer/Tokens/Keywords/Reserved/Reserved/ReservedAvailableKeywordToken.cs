namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedAvailableKeywordToken : ReservedKeywordToken
{
    public ReservedAvailableKeywordToken()
        : base("#available", SwiftTokens.ReservedAvailableId, SwiftTokens.ReservedAvailableIndex)
    { }
}