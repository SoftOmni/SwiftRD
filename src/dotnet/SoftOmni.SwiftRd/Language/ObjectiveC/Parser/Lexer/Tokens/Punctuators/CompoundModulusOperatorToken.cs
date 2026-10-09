using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CompoundModulusOperatorToken : PunctuatorToken<CompoundModulusOperator>
{
    internal CompoundModulusOperatorToken()
        : base(ObjectiveCTokens.CompoundModulusOperatorId, ObjectiveCTokens.CompoundModulusOperatorIndex)
    { }
}