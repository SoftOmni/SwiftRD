using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundLeftShiftOperatorToken : PunctuatorToken<CompoundLeftShiftOperator>
{
    internal CompoundLeftShiftOperatorToken()
        : base(ObjectiveCTokens.CompoundLeftShiftOperatorId, ObjectiveCTokens.CompoundLeftShiftOperatorIndex)
    { }
}