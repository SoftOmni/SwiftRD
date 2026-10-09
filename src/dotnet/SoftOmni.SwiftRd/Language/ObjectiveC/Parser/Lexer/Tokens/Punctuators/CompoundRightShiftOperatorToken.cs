using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundRightShiftOperatorToken : PunctuatorToken<CompoundRightShiftOperator>
{
    internal CompoundRightShiftOperatorToken()
        : base(ObjectiveCTokens.CompoundRightShiftOperatorId, ObjectiveCTokens.CompoundRightShiftOperatorIndex)
    { }
}