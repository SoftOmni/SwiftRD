namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class AsyncKeywordToken : ContextSensitiveKeywordToken
{
    public AsyncKeywordToken()
        : base("async", SwiftTokens.AsyncId, SwiftTokens.AsyncIndex)
    { }
}