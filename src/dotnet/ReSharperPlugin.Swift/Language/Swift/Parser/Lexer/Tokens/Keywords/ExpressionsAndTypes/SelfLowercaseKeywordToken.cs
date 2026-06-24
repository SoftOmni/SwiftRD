using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class SelfLowercaseKeywordToken : ExpressionAndTypeUsableKeywordToken<SelfLowercase>
{
    internal SelfLowercaseKeywordToken()
        : base(SelfLowercase.Keyword, SwiftTokens.SelfLowercaseId, SwiftTokens.SelfLowercaseIndex)
    { }
}
