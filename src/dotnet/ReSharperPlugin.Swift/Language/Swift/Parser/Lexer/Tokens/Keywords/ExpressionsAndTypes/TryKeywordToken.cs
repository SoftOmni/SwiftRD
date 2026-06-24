using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class TryKeywordToken : ExpressionAndTypeUsableKeywordToken<Try>
{
    internal TryKeywordToken()
        : base(Try.Keyword, SwiftTokens.TryId, SwiftTokens.TryIndex)
    { }
}
