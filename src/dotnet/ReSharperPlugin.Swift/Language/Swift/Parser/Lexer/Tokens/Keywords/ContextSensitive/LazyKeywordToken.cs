using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class LazyKeywordToken : ContextSensitiveKeywordToken<Lazy>
{
    internal LazyKeywordToken()
        : base(Lazy.Keyword, SwiftTokens.LazyId, SwiftTokens.LazyIndex)
    { }
}
