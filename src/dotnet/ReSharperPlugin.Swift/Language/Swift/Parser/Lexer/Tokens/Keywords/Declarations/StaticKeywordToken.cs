using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class StaticKeywordToken : DeclarationUsableKeywordToken<Static>
{
    internal StaticKeywordToken()
        : base(Static.Keyword, SwiftTokens.StaticId, SwiftTokens.StaticIndex)
    { }
}