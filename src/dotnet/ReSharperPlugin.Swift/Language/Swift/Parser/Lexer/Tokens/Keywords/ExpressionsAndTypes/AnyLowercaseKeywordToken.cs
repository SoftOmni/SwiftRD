using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class AnyLowercaseKeywordToken : ExpressionAndTypeUsableKeywordToken<AnyLowercase>
{
    internal AnyLowercaseKeywordToken()
        : base(AnyLowercase.Keyword, SwiftTokens.AnyUppercaseId, SwiftTokens.AnyUppercaseIndex)
    { }
}