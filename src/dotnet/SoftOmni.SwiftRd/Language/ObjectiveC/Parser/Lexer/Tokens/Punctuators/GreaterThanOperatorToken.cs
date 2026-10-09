using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class GreaterThanOperatorToken : PunctuatorToken<GreaterThanOperator>
{
    internal GreaterThanOperatorToken()
        : base(ObjectiveCTokens.GreaterThanOperatorId, ObjectiveCTokens.GreaterThanOperatorIndex)
    { }
}
