using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class PrivateKeywordToken : DeclarationUsableKeywordToken<Private>
{
    internal PrivateKeywordToken()
        : base(Private.Keyword, SwiftTokens.PrivateId, SwiftTokens.PrivateIndex)
    { }
}
