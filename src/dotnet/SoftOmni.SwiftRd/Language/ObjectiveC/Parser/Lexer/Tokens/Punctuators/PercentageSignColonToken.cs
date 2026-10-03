using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PercentageSignColonToken : PunctuatorToken<PercentageSignColon>
{
    internal PercentageSignColonToken()
        : base(ObjectiveCTokens.PercentageSignColonId, ObjectiveCTokens.PercentageSignColonIndex)
    { }
}