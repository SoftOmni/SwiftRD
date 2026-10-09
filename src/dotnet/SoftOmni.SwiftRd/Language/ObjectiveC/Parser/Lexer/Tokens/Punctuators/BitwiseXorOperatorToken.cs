using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class BitwiseXorOperatorToken : PunctuatorToken<BitwiseXorOperator>
{
    internal BitwiseXorOperatorToken()
        : base(ObjectiveCTokens.BitwiseXorOperatorId, ObjectiveCTokens.BitwiseXorOperatorIndex)
    { }
}
