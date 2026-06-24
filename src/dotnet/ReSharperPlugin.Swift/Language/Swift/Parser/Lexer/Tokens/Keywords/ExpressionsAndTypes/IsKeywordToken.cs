using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class IsKeywordToken : ExpressionAndTypeUsableKeywordToken<Is>
{
    internal IsKeywordToken()
        : base(Is.Keyword, SwiftTokens.IsId, SwiftTokens.IsIndex)
    { }
}
