using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class AssignmentOperatorToken : PunctuatorToken<AssignmentOperator>
{
    internal AssignmentOperatorToken()
        : base(ObjectiveCTokens.AssignmentOperatorId, ObjectiveCTokens.AssignmentOperatorIndex)
    { }
}