using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.BreakStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class BreakKeywordToken : StatementUsableKeywordToken<Break>
{
    internal BreakKeywordToken()
        : base(Break.Keyword, SwiftTokens.BreakId, SwiftTokens.BreakIndex)
    { }
}
