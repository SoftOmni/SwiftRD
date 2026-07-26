using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class CaseKeywordToken : StatementUsableKeywordToken<Case>
{
    internal CaseKeywordToken()
        : base(Case.Keyword, SwiftTokens.CaseId, SwiftTokens.CaseIndex)
    { }
}
