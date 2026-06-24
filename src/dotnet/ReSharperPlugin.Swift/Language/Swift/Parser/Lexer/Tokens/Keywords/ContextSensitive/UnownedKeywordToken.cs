namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class UnownedKeywordToken : ContextSensitiveKeywordToken
{
    public UnownedKeywordToken()
        : base("unowned", SwiftTokens.UnownedId, SwiftTokens.UnownedIndex)
    { }
}