using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DeferStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class DeferKeywordToken : StatementUsableKeywordToken<Defer>
{
    internal DeferKeywordToken()
        : base(Defer.Keyword, SwiftTokens.DeferId, SwiftTokens.DeferIndex)
    { }
}
