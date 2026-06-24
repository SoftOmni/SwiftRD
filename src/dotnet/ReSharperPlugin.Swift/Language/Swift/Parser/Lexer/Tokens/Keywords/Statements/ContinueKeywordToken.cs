namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ContinueKeywordToken : StatementUsableKeywordToken
{
    public ContinueKeywordToken()
        : base("continue", SwiftTokens.ContinueId, SwiftTokens.ContinueIndex)
    { }
}
