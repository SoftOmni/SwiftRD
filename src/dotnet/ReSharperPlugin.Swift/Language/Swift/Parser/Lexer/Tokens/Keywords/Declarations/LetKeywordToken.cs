using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class LetKeywordToken : DeclarationUsableKeywordToken<Let>
{
    internal LetKeywordToken()
        : base(Let.Keyword, SwiftTokens.LetId, SwiftTokens.LetIndex)
    { }
}
