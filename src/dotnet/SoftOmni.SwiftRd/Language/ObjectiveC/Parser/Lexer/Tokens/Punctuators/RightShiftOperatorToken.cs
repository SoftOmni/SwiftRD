using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class RightShiftOperatorToken : PunctuatorToken<RightShiftOperator>
{
    internal RightShiftOperatorToken()
        : base(ObjectiveCTokens.RightShiftOperatorId, ObjectiveCTokens.RightShiftOperatorIndex)
    { }
}