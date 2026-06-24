namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class GuardKeywordToken : StatementUsableKeywordToken
{
    public GuardKeywordToken()
        : base("guard", SwiftTokens.GuardId, SwiftTokens.GuardIndex)
    { }
}
