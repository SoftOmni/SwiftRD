using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class PublicKeywordToken : DeclarationUsableKeywordToken<Public>
{
    internal PublicKeywordToken()
        : base(Public.Keyword, SwiftTokens.PublicId, SwiftTokens.PublicIndex)
    { }
}