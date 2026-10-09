using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundAddOperatorToken : PunctuatorToken<CompoundAddOperator>
{
    internal CompoundAddOperatorToken()
        : base(ObjectiveCTokens.CompoundAddOperatorId, ObjectiveCTokens.CompoundAddOperatorIndex)
    { }
}
