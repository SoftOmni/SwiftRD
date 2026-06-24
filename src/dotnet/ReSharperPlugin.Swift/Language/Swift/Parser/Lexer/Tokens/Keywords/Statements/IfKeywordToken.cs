namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class IfKeywordToken : StatementUsableKeywordToken
{
    public IfKeywordToken()
        : base("if", SwiftTokens.IfId, SwiftTokens.IfIndex)
    { }
}