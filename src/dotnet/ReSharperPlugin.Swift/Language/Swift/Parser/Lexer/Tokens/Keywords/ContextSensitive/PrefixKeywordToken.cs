using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PrefixKeywordToken : ContextSensitiveKeywordToken<Prefix>
{
    internal PrefixKeywordToken()
        : base(Prefix.Keyword, SwiftTokens.PrefixId, SwiftTokens.PrefixIndex)
    { }
}
