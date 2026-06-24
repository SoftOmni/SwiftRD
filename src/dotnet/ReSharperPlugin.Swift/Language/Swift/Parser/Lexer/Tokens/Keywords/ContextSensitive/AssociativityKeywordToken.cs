namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class AssociativityKeywordToken : ContextSensitiveKeywordToken
{
    public AssociativityKeywordToken()
        : base("associativity", SwiftTokens.AssociativityId, SwiftTokens.AssociativityIndex)
    { }
}