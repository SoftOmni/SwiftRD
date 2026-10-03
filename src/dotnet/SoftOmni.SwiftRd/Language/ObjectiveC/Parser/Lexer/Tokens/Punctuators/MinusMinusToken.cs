using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class MinusMinusToken : PunctuatorToken<MinusMinus>
{
    internal MinusMinusToken()
        : base(ObjectiveCTokens.MinusMinusId, ObjectiveCTokens.MinusMinusIndex)
    { }
}