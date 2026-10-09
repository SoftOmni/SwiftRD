using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class SubtractOrInverseOperatorToken : PunctuatorToken<SubtractOrInverseOperator>
{
    internal SubtractOrInverseOperatorToken()
        : base(ObjectiveCTokens.SubtractOrInverseOperatorId, ObjectiveCTokens.SubtractOrInverseOperatorIndex)
    { }
}