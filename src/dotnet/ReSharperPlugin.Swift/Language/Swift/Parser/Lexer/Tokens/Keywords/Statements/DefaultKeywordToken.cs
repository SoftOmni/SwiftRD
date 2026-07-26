using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class DefaultKeywordToken : StatementUsableKeywordToken<Default>
{
    internal DefaultKeywordToken()
        : base(Default.Keyword, SwiftTokens.DefaultId, SwiftTokens.DefaultIndex)
    { }
}
