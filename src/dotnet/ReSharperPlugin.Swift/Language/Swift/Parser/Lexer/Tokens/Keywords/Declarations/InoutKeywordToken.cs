using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class InoutKeywordToken : DeclarationUsableKeywordToken<InOut>
{
    internal InoutKeywordToken()
        : base(InOut.Keyword, SwiftTokens.InoutId, SwiftTokens.InoutIndex)
    { }
}
