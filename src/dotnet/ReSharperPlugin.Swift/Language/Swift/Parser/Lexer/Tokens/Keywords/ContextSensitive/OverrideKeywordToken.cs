using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class OverrideKeywordToken : ContextSensitiveKeywordToken<Override>
{
    internal OverrideKeywordToken()
        : base(Override.Keyword, SwiftTokens.OverrideId, SwiftTokens.OverrideIndex)
    { }
}
