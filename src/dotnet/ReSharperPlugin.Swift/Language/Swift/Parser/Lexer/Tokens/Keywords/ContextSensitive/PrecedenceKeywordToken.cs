namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PrecedenceKeywordToken : ContextSensitiveKeywordToken
{
    public PrecedenceKeywordToken()
        : base("precedence", SwiftTokens.PrecedenceId, SwiftTokens.PrecedenceIndex)
    { }
}