using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PostfixKeywordToken : ContextSensitiveKeywordToken<Postfix>
{
    internal PostfixKeywordToken()
        : base(Postfix.Keyword, SwiftTokens.PostfixId, SwiftTokens.PostfixIndex)
    { }
}