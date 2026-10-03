using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PercentageSignToken : PunctuatorToken<PercentageSign>
{
    internal PercentageSignToken()
        : base(ObjectiveCTokens.PercentageSignId, ObjectiveCTokens.PercentageSignIndex)
    { }
}