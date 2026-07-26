using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ForKeywordToken : StatementUsableKeywordToken<For>
{
    internal ForKeywordToken()
        : base(For.Keyword, SwiftTokens.ForId, SwiftTokens.ForIndex)
    { }
}
