namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class OverrideKeywordToken : ContextSensitiveKeywordToken
{
    public OverrideKeywordToken()
        : base("override", SwiftTokens.OverrideId, SwiftTokens.OverrideIndex)
    { }
}