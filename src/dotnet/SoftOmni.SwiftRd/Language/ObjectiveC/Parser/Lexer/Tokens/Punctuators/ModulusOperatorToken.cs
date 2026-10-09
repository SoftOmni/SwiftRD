using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ModulusOperatorToken : PunctuatorToken<ModulusOperator>
{
    internal ModulusOperatorToken()
        : base(ObjectiveCTokens.ModulusOperatorId, ObjectiveCTokens.ModulusOperatorIndex)
    { }
}