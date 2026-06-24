namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class FinalKeywordToken : ContextSensitiveKeywordToken
{
    public FinalKeywordToken()
        : base("final", SwiftTokens.FinalId, SwiftTokens.FinalIndex)
    { }
}