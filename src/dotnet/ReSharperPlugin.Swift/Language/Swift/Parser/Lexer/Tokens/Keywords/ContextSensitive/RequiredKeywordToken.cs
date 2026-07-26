using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class RequiredKeywordToken : ContextSensitiveKeywordToken<Required>
{
    internal RequiredKeywordToken()
        : base(Required.Keyword, SwiftTokens.RequiredId, SwiftTokens.RequiredIndex)
    { }
}
