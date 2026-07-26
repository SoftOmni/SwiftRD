using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Images;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedImageLiteralKeywordToken : ReservedKeywordToken<ReservedImageLiteralKeyword>
{
    internal ReservedImageLiteralKeywordToken()
        : base(ReservedImageLiteralKeyword.Keyword, SwiftTokens.ReservedImageLiteralId,
            SwiftTokens.ReservedImageLiteralIndex)
    { }
}