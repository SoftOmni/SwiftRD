
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

using Internal = Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords.Internal;

public class InternalKeywordToken : DeclarationUsableKeywordToken<Internal>
{
    internal InternalKeywordToken()
        : base(Internal.Keyword, SwiftTokens.InternalId, SwiftTokens.InternalIndex)
    { }
}
