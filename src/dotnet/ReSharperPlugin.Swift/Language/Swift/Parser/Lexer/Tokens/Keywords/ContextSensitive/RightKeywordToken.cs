namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class RightKeywordToken : ContextSensitiveKeywordToken
{
    public RightKeywordToken()
        : base("right", SwiftTokens.RightId, SwiftTokens.RightIndex)
    { }
}