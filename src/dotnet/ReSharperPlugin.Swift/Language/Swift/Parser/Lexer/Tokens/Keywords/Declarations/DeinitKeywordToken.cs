using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class DeinitKeywordToken : DeclarationUsableKeywordToken<DeInit>
{
    internal DeinitKeywordToken()
        : base(DeInit.Keyword, SwiftTokens.DeinitId, SwiftTokens.DeinitIndex)
    { }
}
