namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ElseKeywordToken : StatementUsableKeywordToken
{
    public ElseKeywordToken()
        : base("else", SwiftTokens.ElseId, SwiftTokens.ElseIndex)
    { }
}
