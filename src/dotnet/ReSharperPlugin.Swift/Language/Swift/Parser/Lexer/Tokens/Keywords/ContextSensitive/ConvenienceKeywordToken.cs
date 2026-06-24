namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class ConvenienceKeywordToken : ContextSensitiveKeywordToken
{
    public ConvenienceKeywordToken()
        : base("convenience", SwiftTokens.ConvenienceId, SwiftTokens.ConvenienceIndex)
    { }
}