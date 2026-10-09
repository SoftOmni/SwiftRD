using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class LeftShiftOperatorToken : PunctuatorToken<LeftShiftOperator>
{
    internal LeftShiftOperatorToken()
        : base(ObjectiveCTokens.LeftShiftOperatorId, ObjectiveCTokens.LeftShiftOperatorIndex)
    { }
}