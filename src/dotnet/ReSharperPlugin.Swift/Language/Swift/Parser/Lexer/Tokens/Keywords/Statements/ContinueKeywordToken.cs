using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ContinueStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ContinueKeywordToken : StatementUsableKeywordToken<Continue>
{
    internal ContinueKeywordToken()
        : base(Continue.Keyword, SwiftTokens.ContinueId, SwiftTokens.ContinueIndex)
    { }
}
