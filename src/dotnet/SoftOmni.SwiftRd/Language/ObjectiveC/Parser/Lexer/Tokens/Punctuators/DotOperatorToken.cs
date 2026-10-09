using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DotOperatorToken : PunctuatorToken<DotOperator>
{
    internal DotOperatorToken()
        : base(ObjectiveCTokens.DotOperatorId, ObjectiveCTokens.DotOperatorIndex)
    { }
}
