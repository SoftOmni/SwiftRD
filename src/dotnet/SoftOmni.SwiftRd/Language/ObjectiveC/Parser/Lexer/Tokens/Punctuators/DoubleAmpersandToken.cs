using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleAmpersandToken : PunctuatorToken<DoubleAmpersand>
{
    internal DoubleAmpersandToken()
        : base(ObjectiveCTokens.DoubleAmpersandId, ObjectiveCTokens.DoubleAmpersandIndex)
    { }
}