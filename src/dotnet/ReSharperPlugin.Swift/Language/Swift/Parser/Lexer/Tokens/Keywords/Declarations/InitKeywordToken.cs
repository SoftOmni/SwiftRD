using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class InitKeywordToken : DeclarationUsableKeywordToken<Init>
{
    internal InitKeywordToken()
        : base(Init.Keyword, SwiftTokens.InitId, SwiftTokens.InitIndex)
    { }
}