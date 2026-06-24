namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class SetKeywordToken : ContextSensitiveKeywordToken
{
    public SetKeywordToken()
        : base("set", SwiftTokens.SetId, SwiftTokens.SetIndex)
    { }
}