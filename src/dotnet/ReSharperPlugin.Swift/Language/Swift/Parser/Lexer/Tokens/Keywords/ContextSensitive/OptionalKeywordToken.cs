namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class OptionalKeywordToken : ContextSensitiveKeywordToken
{
    public OptionalKeywordToken()
        : base("optional", SwiftTokens.OptionalId, SwiftTokens.OptionalIndex)
    { }
}