using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.FallthroughStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class FallthroughKeywordToken : StatementUsableKeywordToken<Fallthrough>
{
    internal FallthroughKeywordToken()
        : base(Fallthrough.Keyword, SwiftTokens.FallthroughId, SwiftTokens.FallthroughIndex)
    { }
}
