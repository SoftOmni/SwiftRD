using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class PrivateKeywordToken : DeclarationUsableKeywordToken<Private>
{
    public PrivateKeywordToken()
        : base(Private.Keyword, SwiftTokens.PrivateId, SwiftTokens.PrivateIndex)
    { }
}
