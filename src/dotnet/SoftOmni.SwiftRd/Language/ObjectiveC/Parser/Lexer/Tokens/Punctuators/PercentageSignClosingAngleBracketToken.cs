using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PercentageSignClosingAngleBracketToken : PunctuatorToken<PercentageSignClosingAngleBracket>
{
    internal PercentageSignClosingAngleBracketToken()
        : base(ObjectiveCTokens.PercentageSignClosingAngleBracketId, ObjectiveCTokens.PercentageSignClosingAngleBracketIndex)
    { }
}