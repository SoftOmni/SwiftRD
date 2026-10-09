using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundDivideOperatorToken : PunctuatorToken<CompoundDivideOperator>
{
    internal CompoundDivideOperatorToken()
        : base(ObjectiveCTokens.CompoundDivideOperatorId, ObjectiveCTokens.CompoundDivideOperatorIndex)
    { }
}