namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class FallthroughKeywordToken : StatementUsableKeywordToken
{
    public FallthroughKeywordToken()
        : base("fallthrough", SwiftTokens.FallthroughId, SwiftTokens.FallthroughIndex)
    { }
}
