using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ThrowStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ThrowKeywordToken : StatementUsableKeywordToken<Throw>
{
    internal ThrowKeywordToken()
        : base(Throw.Keyword, SwiftTokens.ThrowId, SwiftTokens.ThrowIndex)
    { }
}