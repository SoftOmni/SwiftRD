using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundBitwiseOrOperatorToken : PunctuatorToken<CompoundBitwiseOrOperator>
{
    internal CompoundBitwiseOrOperatorToken()
        : base(ObjectiveCTokens.CompoundBitwiseOrOperatorId, ObjectiveCTokens.CompoundBitwiseOrOperatorIndex)
    { }
}