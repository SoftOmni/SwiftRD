using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class SwitchKeywordToken : StatementUsableKeywordToken<Switch>
{
    internal SwitchKeywordToken()
        : base(Switch.Keyword, SwiftTokens.SwitchId, SwiftTokens.SwitchIndex)
    { }
}
