using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class NotEqualsOperatorToken : PunctuatorToken<NotEqualsOperator>
{
    internal NotEqualsOperatorToken()
        : base(ObjectiveCTokens.NotEqualsOperatorId, ObjectiveCTokens.NotEqualsOperatorIndex)
    { }
}