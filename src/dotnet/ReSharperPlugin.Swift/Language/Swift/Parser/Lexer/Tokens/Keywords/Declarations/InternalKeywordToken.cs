using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class InternalKeywordToken : DeclarationUsableKeywordToken<Internal>
{
    internal InternalKeywordToken()
        : base(Internal.Keyword, SwiftTokens.InternalId, SwiftTokens.InternalIndex)
    { }
}