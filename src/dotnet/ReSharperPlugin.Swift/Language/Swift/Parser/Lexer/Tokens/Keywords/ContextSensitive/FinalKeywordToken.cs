using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class FinalKeywordToken : ContextSensitiveKeywordToken<Final>
{
    internal FinalKeywordToken()
        : base(Final.Keyword, SwiftTokens.FinalId, SwiftTokens.FinalIndex)
    { }
}