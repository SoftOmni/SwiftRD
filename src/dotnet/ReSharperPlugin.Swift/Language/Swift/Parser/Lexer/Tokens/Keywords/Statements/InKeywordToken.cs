using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class InKeywordToken : StatementUsableKeywordToken<In>
{
    internal InKeywordToken()
        : base(In.Keyword, SwiftTokens.InId, SwiftTokens.InIndex)
    { }
}
