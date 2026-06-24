using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class SelfUppercaseKeywordToken : ExpressionAndTypeUsableKeywordToken<Self>
{
    public SelfUppercaseKeywordToken()
        : base("Self", SwiftTokens.SelfUppercaseId, SwiftTokens.SelfUppercaseIndex)
    { }
}
