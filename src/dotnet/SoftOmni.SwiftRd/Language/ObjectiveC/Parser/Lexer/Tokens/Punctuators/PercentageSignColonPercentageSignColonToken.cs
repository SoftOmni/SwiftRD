using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PercentageSignColonPercentageSignColonToken : PunctuatorToken<PercentageSignColonPercentageSignColon>
{
    internal PercentageSignColonPercentageSignColonToken()
        : base(ObjectiveCTokens.PercentageSignColonPercentageSignColonId, ObjectiveCTokens.PercentageSignColonPercentageSignColonIndex)
    { }
}