using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class MutatingKeywordToken : ContextSensitiveKeywordToken<Mutating>
{
    internal MutatingKeywordToken()
        : base(Mutating.Keyword, SwiftTokens.MutatingId, SwiftTokens.MutatingIndex)
    { }
}
