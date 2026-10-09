using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundMultiplyOperatorToken : PunctuatorToken<CompoundMultiplyOperator>
{
    internal CompoundMultiplyOperatorToken()
        : base(ObjectiveCTokens.CompoundMultiplyOperatorId, ObjectiveCTokens.CompoundMultiplyOperatorIndex)
    { }
}