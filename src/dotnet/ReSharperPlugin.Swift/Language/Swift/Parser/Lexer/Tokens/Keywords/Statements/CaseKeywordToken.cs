namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class CaseKeywordToken : StatementUsableKeywordToken
{
    public CaseKeywordToken()
        : base("case", SwiftTokens.CaseId, SwiftTokens.CaseIndex)
    { }
}