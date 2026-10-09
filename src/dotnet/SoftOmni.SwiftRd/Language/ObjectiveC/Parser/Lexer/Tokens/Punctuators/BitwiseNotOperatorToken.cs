using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class BitwiseNotOperatorToken : PunctuatorToken<BitwiseNotOperator>
{
    internal BitwiseNotOperatorToken()
        : base(ObjectiveCTokens.BitwiseNotOperatorId, ObjectiveCTokens.BitwiseNotOperatorIndex)
    { }
}
