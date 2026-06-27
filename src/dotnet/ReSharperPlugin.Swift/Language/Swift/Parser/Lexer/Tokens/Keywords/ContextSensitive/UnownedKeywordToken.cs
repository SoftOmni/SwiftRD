using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class UnownedKeywordToken : ContextSensitiveKeywordToken<Unowned>
{
    internal UnownedKeywordToken()
        : base(Unowned.Keyword, SwiftTokens.UnownedId, SwiftTokens.UnownedIndex)
    { }
}
