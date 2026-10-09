using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class LogicalNotOperatorToken : PunctuatorToken<LogicalNotOperator>
{
    internal LogicalNotOperatorToken()
        : base(ObjectiveCTokens.LogicalNotOperatorId, ObjectiveCTokens.LogicalNotOperatorIndex)
    { }
}