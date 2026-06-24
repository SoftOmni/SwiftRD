namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PrefixKeywordToken : ContextSensitiveKeywordToken
{
    public PrefixKeywordToken()
        : base("prefix", SwiftTokens.PrefixId, SwiftTokens.PrefixIndex)
    { }
}