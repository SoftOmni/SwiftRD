using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class ThrowsKeywordToken : ExpressionAndTypeUsableKeywordToken<Throws>
{
    internal ThrowsKeywordToken()
        : base(Throws.Keyword, SwiftTokens.ThrowsId, SwiftTokens.ThrowsIndex)
    { }
}
