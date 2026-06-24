namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class RepeatKeywordToken : StatementUsableKeywordToken
{
    public RepeatKeywordToken()
        : base("repeat", SwiftTokens.RepeatId, SwiftTokens.RepeatIndex)
    { }
}

