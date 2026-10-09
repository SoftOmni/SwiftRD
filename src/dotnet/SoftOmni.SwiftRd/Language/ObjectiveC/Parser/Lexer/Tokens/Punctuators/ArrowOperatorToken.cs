using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ArrowOperatorToken : PunctuatorToken<ArrowOperator>
{
    internal ArrowOperatorToken()
        : base(ObjectiveCTokens.ArrowOperatorId, ObjectiveCTokens.ArrowOperatorIndex)
    { }
}