namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class RequiredKeywordToken : ContextSensitiveKeywordToken
{
    public RequiredKeywordToken()
        : base("required", SwiftTokens.RequiredId, SwiftTokens.RequiredIndex)
    { }
}