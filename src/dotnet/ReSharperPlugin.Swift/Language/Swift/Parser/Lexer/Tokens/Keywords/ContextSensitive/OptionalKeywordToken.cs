using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class OptionalKeywordToken : ContextSensitiveKeywordToken<Optional>
{
    internal OptionalKeywordToken()
        : base(Optional.Keyword, SwiftTokens.OptionalId, SwiftTokens.OptionalIndex)
    { }
}
