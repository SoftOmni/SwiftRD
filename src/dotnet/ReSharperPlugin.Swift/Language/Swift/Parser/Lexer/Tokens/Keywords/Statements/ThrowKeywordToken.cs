namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ThrowKeywordToken : StatementUsableKeywordToken
{
    public ThrowKeywordToken()
        : base("throw", SwiftTokens.ThrowId, SwiftTokens.ThrowIndex)
    { }
}