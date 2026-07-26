using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class GuardKeywordToken : StatementUsableKeywordToken<Guard>
{
    internal GuardKeywordToken()
        : base(Guard.Keyword, SwiftTokens.GuardId, SwiftTokens.GuardIndex)
    { }
}
