namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class NonMutatingKeywordToken : ContextSensitiveKeywordToken
{
    public NonMutatingKeywordToken()
        : base("nonmutating", SwiftTokens.NonMutatingId, SwiftTokens.NonMutatingIndex)
    { }
}