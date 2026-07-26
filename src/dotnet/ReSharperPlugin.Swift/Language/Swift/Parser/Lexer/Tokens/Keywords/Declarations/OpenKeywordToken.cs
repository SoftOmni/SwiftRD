using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class OpenKeywordToken : DeclarationUsableKeywordToken<Open>
{
    internal OpenKeywordToken()
        : base(Open.Keyword, SwiftTokens.OpenId, SwiftTokens.OpenIndex)
    { }
}
