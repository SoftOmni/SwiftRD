using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.AnyTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class AnyUppercaseKeywordToken : ExpressionAndTypeUsableKeywordToken<AnyUppercase>
{
    internal AnyUppercaseKeywordToken()
        : base(AnyUppercase.Keyword, SwiftTokens.AnyLowercaseId, SwiftTokens.AnyLowercaseIndex)
    { }
}
