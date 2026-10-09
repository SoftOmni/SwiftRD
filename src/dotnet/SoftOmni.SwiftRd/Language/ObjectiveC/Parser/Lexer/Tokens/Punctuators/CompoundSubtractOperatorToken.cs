using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundSubtractOperatorToken : PunctuatorToken<CompoundSubtractOperator>
{
    internal CompoundSubtractOperatorToken()
        : base(ObjectiveCTokens.CompoundSubtractOperatorId, ObjectiveCTokens.CompoundSubtractOperatorIndex)
    { }
}