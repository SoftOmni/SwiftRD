using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundBitwiseAndOperatorToken : PunctuatorToken<CompoundBitwiseAndOperator>
{
    internal CompoundBitwiseAndOperatorToken()
        : base(ObjectiveCTokens.CompoundBitwiseAndOperatorId, ObjectiveCTokens.CompoundBitwiseAndOperatorIndex)
    { }
}