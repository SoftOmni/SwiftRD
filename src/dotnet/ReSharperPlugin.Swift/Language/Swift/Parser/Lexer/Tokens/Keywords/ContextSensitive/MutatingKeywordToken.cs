namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class MutatingKeywordToken : ContextSensitiveKeywordToken
{
    public MutatingKeywordToken()
        : base("mutating", SwiftTokens.MutatingId, SwiftTokens.MutatingIndex)
    { }
}