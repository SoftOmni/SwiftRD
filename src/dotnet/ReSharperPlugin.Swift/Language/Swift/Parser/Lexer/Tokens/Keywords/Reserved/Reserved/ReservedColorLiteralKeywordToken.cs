using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Colors;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedColorLiteralKeywordToken : ReservedKeywordToken<ReservedColorLiteralKeyword>
{
    internal ReservedColorLiteralKeywordToken()
        : base(ReservedColorLiteralKeyword.Keyword, SwiftTokens.ReservedColorLiteralId, SwiftTokens.ReservedColorLiteralIndex)
    { }
}
