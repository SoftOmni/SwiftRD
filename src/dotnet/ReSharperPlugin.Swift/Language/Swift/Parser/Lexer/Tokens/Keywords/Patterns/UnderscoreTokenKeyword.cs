using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Wildcards;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Patterns;

public class UnderscoreTokenKeyword : PatternUsableKeywordToken<Wildcard>
{
    internal UnderscoreTokenKeyword()
        : base(Wildcard.Keyword, SwiftTokens.UnderscoreId, SwiftTokens.UnderscoreIndex)
    { }
}
