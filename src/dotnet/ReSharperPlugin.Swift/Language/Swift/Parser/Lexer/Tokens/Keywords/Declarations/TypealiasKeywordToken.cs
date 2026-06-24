using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class TypealiasKeywordToken : DeclarationUsableKeywordToken<TypeAliasKeyword>
{
    internal TypealiasKeywordToken()
        : base(TypeAliasKeyword.Keyword, SwiftTokens.TypealiasId, SwiftTokens.TypealiasIndex)
    { }
}
