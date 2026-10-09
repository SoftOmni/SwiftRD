using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class IncrementOperatorToken : PunctuatorToken<IncrementOperator>
{
    internal IncrementOperatorToken()
        : base(ObjectiveCTokens.IncrementOperatorId, ObjectiveCTokens.IncrementOperatorIndex)
    { }
}