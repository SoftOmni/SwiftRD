using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DecrementOperatorToken : PunctuatorToken<DecrementOperator>
{
    internal DecrementOperatorToken()
        : base(ObjectiveCTokens.DecrementOperatorId, ObjectiveCTokens.DecrementOperatorIndex)
    { }
}