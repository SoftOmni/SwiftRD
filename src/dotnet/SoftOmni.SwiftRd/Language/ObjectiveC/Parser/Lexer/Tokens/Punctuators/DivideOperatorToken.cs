using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DivideOperatorToken : PunctuatorToken<DivideOperator>
{
    internal DivideOperatorToken()
        : base(ObjectiveCTokens.DivideOperatorId, ObjectiveCTokens.DivideOperatorIndex)
    { }
}