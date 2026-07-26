using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class InfixKeywordToken : ContextSensitiveKeywordToken<Infix>
{
    internal InfixKeywordToken()
        : base(Infix.Keyword, SwiftTokens.InfixId, SwiftTokens.InfixIndex)
    { }
}
