using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ExtensionKeywordToken : DeclarationUsableKeywordToken<ExtensionKeyword>
{
    internal ExtensionKeywordToken()
        : base(ExtensionKeyword.Keyword, SwiftTokens.ExtensionId, SwiftTokens.ExtensionIndex)
    { }
}
