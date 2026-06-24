namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class IndirectKeywordToken : ContextSensitiveKeywordToken
{
    public IndirectKeywordToken()
        : base("indirect", SwiftTokens.IndirectId, SwiftTokens.IndirectIndex)
    { }
}