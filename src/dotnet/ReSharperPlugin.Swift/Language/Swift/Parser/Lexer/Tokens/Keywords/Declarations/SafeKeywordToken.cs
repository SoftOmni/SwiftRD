using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class SafeKeywordToken : DeclarationUsableKeywordToken<Safe>
{
    internal SafeKeywordToken()
        : base(Safe.Keyword, SwiftTokens.SafeId, SwiftTokens.SafeIndex)
    { }
}