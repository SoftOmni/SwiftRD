using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class RethrowsKeywordToken : DeclarationUsableKeywordToken<Rethrows>
{
    internal RethrowsKeywordToken()
        : base(Rethrows.Keyword, SwiftTokens.RethrowsId, SwiftTokens.RethrowsIndex)
    { }
}