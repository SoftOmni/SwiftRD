using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class EqualityOperatorToken : PunctuatorToken<EqualityOperator>
{
    internal EqualityOperatorToken()
        : base(ObjectiveCTokens.EqualityOperatorId, ObjectiveCTokens.EqualityOperatorIndex)
    { }
}
