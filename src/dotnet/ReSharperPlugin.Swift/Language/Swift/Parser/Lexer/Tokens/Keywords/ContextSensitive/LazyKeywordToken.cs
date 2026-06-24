namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class LazyKeywordToken : ContextSensitiveKeywordToken
{
    public LazyKeywordToken()
        : base("lazy", SwiftTokens.LazyId, SwiftTokens.LazyIndex)
    { }
}