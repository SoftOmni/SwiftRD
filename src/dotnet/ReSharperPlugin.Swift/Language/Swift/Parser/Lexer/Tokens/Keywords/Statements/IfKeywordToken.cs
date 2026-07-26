using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class IfKeywordToken : StatementUsableKeywordToken<If>
{
    internal IfKeywordToken()
        : base(If.Keyword, SwiftTokens.IfId, SwiftTokens.IfIndex)
    { }
}
