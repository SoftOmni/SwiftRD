using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class NonMutatingKeywordToken : ContextSensitiveKeywordToken<NonMutating>
{
    internal NonMutatingKeywordToken()
        : base(NonMutating.Keyword, SwiftTokens.NonMutatingId, SwiftTokens.NonMutatingIndex)
    { }
}
