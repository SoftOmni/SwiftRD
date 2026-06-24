namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PostfixKeywordToken : ContextSensitiveKeywordToken
{
    public PostfixKeywordToken()
        : base("postfix", SwiftTokens.PostfixId, SwiftTokens.PostfixIndex)
    { }
}