namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class SwitchKeywordToken : StatementUsableKeywordToken
{
    public SwitchKeywordToken()
        : base("switch", SwiftTokens.SwitchId, SwiftTokens.SwitchIndex)
    { }
}
