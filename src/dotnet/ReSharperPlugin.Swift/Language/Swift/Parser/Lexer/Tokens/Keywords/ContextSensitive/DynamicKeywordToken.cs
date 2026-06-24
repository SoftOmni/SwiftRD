namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class DynamicKeywordToken : ContextSensitiveKeywordToken
{
    public DynamicKeywordToken()
        : base("dynamic", SwiftTokens.DynamicId, SwiftTokens.DynamicIndex)
    { }
}