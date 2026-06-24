using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class AsKeywordToken : ExpressionAndTypeUsableKeywordToken<As>
{
    internal AsKeywordToken()
        : base(As.Keyword, SwiftTokens.AsId, SwiftTokens.AsIndex)
    { }
}