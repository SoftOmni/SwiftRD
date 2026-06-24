namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class BreakKeywordToken : StatementUsableKeywordToken
{
    public BreakKeywordToken()
        : base("operator", SwiftTokens.BreakId, SwiftTokens.BreakIndex)
    { }
}
