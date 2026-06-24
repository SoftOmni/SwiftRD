namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class DoKeywordToken : StatementUsableKeywordToken
{
    public DoKeywordToken()
        : base("do", SwiftTokens.DoId, SwiftTokens.DoIndex)
    { }
}
