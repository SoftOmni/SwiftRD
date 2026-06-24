using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class UnsafeKeywordToken : DeclarationUsableKeywordToken<Unsafe>
{
    internal UnsafeKeywordToken()
        : base(Unsafe.Keyword, SwiftTokens.UnsafeId, SwiftTokens.UnsafeIndex)
    { }
}