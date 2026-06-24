namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class InfixKeywordToken : ContextSensitiveKeywordToken
{
    public InfixKeywordToken()
        : base("infix", SwiftTokens.InfixId, SwiftTokens.InfixIndex)
    { }
}