namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class WhileKeywordToken : StatementUsableKeywordToken
{
    public WhileKeywordToken()
        : base("while", SwiftTokens.WhileId, SwiftTokens.WhileIndex)
    { }
}
