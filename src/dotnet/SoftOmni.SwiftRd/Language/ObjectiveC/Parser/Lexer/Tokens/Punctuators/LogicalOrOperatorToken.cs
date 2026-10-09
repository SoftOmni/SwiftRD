using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class LogicalOrOperatorToken : PunctuatorToken<LogicalOrOperator>
{
    internal LogicalOrOperatorToken()
        : base(ObjectiveCTokens.LogicalOrOperatorId, ObjectiveCTokens.LogicalOrOperatorIndex)
    { }
}