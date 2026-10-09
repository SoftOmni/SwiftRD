using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class TernaryOperatorQuestionResponseSeparatorToken : PunctuatorToken<TernaryOperatorQuestionResponseSeparator>
{
    internal TernaryOperatorQuestionResponseSeparatorToken()
        : base(ObjectiveCTokens.TernaryOperatorQuestionResponseSeparatorId, ObjectiveCTokens.TernaryOperatorQuestionResponseSeparatorIndex)
    { }
}
