using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class LogicalAndOperatorToken : PunctuatorToken<LogicalAndOperator>
{
    internal LogicalAndOperatorToken()
        : base(ObjectiveCTokens.LogicalAndOperatorId, ObjectiveCTokens.LogicalAndOperatorIndex)
    { }
}