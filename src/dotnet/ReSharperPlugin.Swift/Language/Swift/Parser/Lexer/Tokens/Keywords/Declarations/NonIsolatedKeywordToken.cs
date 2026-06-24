using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class NonIsolatedKeywordToken : DeclarationUsableKeywordToken<NonIsolated>
{
    internal NonIsolatedKeywordToken()
        : base(NonIsolated.Keyword, SwiftTokens.NonIsolatedId, SwiftTokens.NonIsolatedIndex)
    { }
}
