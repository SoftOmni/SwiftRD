namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PrecedenceKeywordToken : ContextSensitiveKeywordToken<Precedence>
{
    internal PrecedenceKeywordToken()
        : base("precedence", SwiftTokens.PrecedenceId, SwiftTokens.PrecedenceIndex)
    { }
}
