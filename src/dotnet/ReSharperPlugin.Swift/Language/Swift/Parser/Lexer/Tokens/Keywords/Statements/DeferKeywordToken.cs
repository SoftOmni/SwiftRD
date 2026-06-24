namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class DeferKeywordToken : StatementUsableKeywordToken
{
    public DeferKeywordToken()
        : base("defer", SwiftTokens.DeferId, SwiftTokens.DeferIndex)
    { }
}
