namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class WhereKeywordToken : StatementUsableKeywordToken
{
    public WhereKeywordToken()
        : base("where", SwiftTokens.WhereId, SwiftTokens.WhereIndex)
    { }
}