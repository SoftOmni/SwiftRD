namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class DefaultKeywordToken : StatementUsableKeywordToken
{
    public DefaultKeywordToken()
        : base("default", SwiftTokens.DefaultId, SwiftTokens.DefaultIndex)
    { }
}