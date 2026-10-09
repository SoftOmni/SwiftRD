using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class BitwiseOrOperatorToken : PunctuatorToken<BitwiseOrOperator>
{
    internal BitwiseOrOperatorToken()
        : base(ObjectiveCTokens.BitwiseOrOperatorId, ObjectiveCTokens.BitwiseOrOperatorIndex)
    { }
}