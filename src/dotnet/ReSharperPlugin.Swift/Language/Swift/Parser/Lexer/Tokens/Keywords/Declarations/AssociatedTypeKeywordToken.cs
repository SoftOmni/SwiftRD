using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class AssociatedTypeKeywordToken : DeclarationUsableKeywordToken<AssociatedType>
{
    internal AssociatedTypeKeywordToken()
        : base(AssociatedType.Keyword, SwiftTokens.AssociatedTypeId, SwiftTokens.AssociatedTypeIndex)
    { }
}