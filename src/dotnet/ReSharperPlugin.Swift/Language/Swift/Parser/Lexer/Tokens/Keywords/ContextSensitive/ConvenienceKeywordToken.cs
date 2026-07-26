using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class ConvenienceKeywordToken : ContextSensitiveKeywordToken<Convenience>
{
    internal ConvenienceKeywordToken()
        : base(Convenience.Keyword, SwiftTokens.ConvenienceId, SwiftTokens.ConvenienceIndex)
    { }
}
