using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ExtensionKeywordToken : DeclarationUsableKeywordToken<Extension>
{
    internal ExtensionKeywordToken()
        : base(Extension.Keyword, SwiftTokens.ExtensionId, SwiftTokens.ExtensionIndex)
    { }
}
