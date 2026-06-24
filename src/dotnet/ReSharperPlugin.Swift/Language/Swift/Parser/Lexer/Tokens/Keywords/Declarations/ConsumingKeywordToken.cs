using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ConsumingKeywordToken : DeclarationUsableKeywordToken<Consuming>
{
    internal ConsumingKeywordToken()
        : base(Consuming.Keyword, SwiftTokens.ConsumingId, SwiftTokens.ConsumingIndex)
    { }
}
