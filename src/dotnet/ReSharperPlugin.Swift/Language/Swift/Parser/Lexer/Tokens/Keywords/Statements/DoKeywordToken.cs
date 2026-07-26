using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class DoKeywordToken : StatementUsableKeywordToken<Do>
{
    internal DoKeywordToken()
        : base(Do.Keyword, SwiftTokens.DoId, SwiftTokens.DoIndex)
    { }
}
