using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PercentageSignEqualsSignToken : PunctuatorToken<PercentageSignEqualsSign>
{
    internal PercentageSignEqualsSignToken()
        : base(ObjectiveCTokens.PercentageSignEqualsSignId, ObjectiveCTokens.PercentageSignEqualsSignIndex)
    { }
}