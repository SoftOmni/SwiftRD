namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class GetKeywordToken : ContextSensitiveKeywordToken
{
    public GetKeywordToken()
        : base("get", SwiftTokens.GetId, SwiftTokens.GetIndex)
    { }
}