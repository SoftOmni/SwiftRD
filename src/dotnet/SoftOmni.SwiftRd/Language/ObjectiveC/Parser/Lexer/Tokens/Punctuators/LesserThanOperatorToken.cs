using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class LesserThanOperatorToken : PunctuatorToken<LesserThanOperator>
{
    internal LesserThanOperatorToken()
        : base(ObjectiveCTokens.LesserThanOperatorId, ObjectiveCTokens.LesserThanOperatorIndex)
    { }
}
