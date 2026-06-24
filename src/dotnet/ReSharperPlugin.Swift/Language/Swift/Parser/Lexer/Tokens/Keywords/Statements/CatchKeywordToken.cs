namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class CatchKeywordToken : StatementUsableKeywordToken
{
    public CatchKeywordToken()
        : base("catch", SwiftTokens.CatchId, SwiftTokens.CatchIndex)
    { }
}