namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class NoneKeywordToken : ContextSensitiveKeywordToken
{
    public NoneKeywordToken()
        : base("none", SwiftTokens.NoneId, SwiftTokens.NoneIndex)
    { }
}