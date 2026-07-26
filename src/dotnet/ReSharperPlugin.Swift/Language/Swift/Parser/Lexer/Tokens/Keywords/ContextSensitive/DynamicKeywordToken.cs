using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class DynamicKeywordToken : ContextSensitiveKeywordToken<Dynamic>
{
    internal DynamicKeywordToken()
        : base(Dynamic.Keyword, SwiftTokens.DynamicId, SwiftTokens.DynamicIndex)
    { }
}
