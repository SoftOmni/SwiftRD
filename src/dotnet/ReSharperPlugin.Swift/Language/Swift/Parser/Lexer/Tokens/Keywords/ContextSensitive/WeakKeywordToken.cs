namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class WeakKeywordToken : ContextSensitiveKeywordToken
{
    public WeakKeywordToken()
        : base("weak", SwiftTokens.WeakId, SwiftTokens.WeakIndex)
    { }
}