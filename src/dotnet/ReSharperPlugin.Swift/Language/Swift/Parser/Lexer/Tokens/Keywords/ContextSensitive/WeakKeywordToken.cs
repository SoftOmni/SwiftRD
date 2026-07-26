using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class WeakKeywordToken : ContextSensitiveKeywordToken<Weak>
{
    internal WeakKeywordToken()
        : base(Weak.Keyword, SwiftTokens.WeakId, SwiftTokens.WeakIndex)
    { }
}
