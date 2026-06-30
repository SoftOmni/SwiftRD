using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedSelectorKeywordToken : ReservedKeywordToken<SelectorKeyword>
{
    internal ReservedSelectorKeywordToken()
        : base(SelectorKeyword.Keyword, SwiftTokens.ReservedSelectorId, SwiftTokens.ReservedSelectorIndex)
    { }
}
