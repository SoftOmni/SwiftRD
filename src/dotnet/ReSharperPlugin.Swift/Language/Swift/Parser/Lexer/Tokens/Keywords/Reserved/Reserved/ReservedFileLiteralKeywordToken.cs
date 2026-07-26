using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Files;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedFileLiteralKeywordToken : ReservedKeywordToken<ReservedFileLiteralKeyword>
{
    internal ReservedFileLiteralKeywordToken()
        : base(ReservedFileLiteralKeyword.Keyword, SwiftTokens.ReservedFileLiteralId, SwiftTokens.ReservedFileLiteralIndex)
    { }
}
