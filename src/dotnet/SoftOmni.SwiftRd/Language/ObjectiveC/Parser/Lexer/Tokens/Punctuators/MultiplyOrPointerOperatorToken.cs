using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class MultiplyOrPointerOperatorToken : PunctuatorToken<MultiplyOrPointerOperator>
{
    internal MultiplyOrPointerOperatorToken()
        : base(ObjectiveCTokens.MultiplyOrPointerOperatorId, ObjectiveCTokens.MultiplyOrPointerOperatorIndex)
    { }
}
