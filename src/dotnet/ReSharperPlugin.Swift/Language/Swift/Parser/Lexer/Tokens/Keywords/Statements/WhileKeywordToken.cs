using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class WhileKeywordToken : StatementUsableKeywordToken<While>
{
    internal WhileKeywordToken()
        : base(While.Keyword, SwiftTokens.WhileId, SwiftTokens.WhileIndex)
    { }
}
