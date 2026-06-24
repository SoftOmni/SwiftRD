namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class LeftKeywordToken : ContextSensitiveKeywordToken
{
    public LeftKeywordToken()
        : base("left", SwiftTokens.LeftId, SwiftTokens.LeftIndex)
    { }
}