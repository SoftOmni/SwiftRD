namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ReturnKeywordToken : StatementUsableKeywordToken
{
    public ReturnKeywordToken()
        : base("return", SwiftTokens.ReturnId, SwiftTokens.ReturnIndex)
    { }
}
