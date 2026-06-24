namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class WillSetKeywordToken : ContextSensitiveKeywordToken
{
    public WillSetKeywordToken()
        : base("willSet", SwiftTokens.WillSetId, SwiftTokens.WillSetIndex)
    { }
}