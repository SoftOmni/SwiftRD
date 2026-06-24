using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class SuperKeywordToken : ExpressionAndTypeUsableKeywordToken<Super>
{
    internal SuperKeywordToken()
        : base(Super.Keyword, SwiftTokens.SuperId, SwiftTokens.SuperIndex)
    { }
}
