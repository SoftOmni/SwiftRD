using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundBitwiseXorOperatorToken : PunctuatorToken<CompoundBitwiseXorOperator>
{
    internal CompoundBitwiseXorOperatorToken()
        : base(ObjectiveCTokens.CompoundBitwiseXorOperatorId, ObjectiveCTokens.CompoundBitwiseXorOperatorIndex)
    { }
}