using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class BitwiseAndOperatorToken : PunctuatorToken<BitwiseAndOperator>
{
    internal BitwiseAndOperatorToken()
        : base(BitwiseAndOperator.Value, ObjectiveCTokens.BitwiseAndOperatorIndex)
    { }
}
