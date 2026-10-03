using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PeriodToken : PunctuatorToken<Period>
{
    internal PeriodToken()
        : base(ObjectiveCTokens.PeriodId, ObjectiveCTokens.PeriodIndex)
    { }
}
