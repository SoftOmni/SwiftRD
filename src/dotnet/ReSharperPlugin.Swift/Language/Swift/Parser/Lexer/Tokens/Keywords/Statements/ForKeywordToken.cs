namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ForKeywordToken : StatementUsableKeywordToken
{
    public ForKeywordToken()
        : base("for", SwiftTokens.ForId, SwiftTokens.ForIndex)
    { }
}