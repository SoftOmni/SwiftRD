using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class MinusToken : PunctuatorToken<Minus>
{
    internal MinusToken()
        : base(ObjectiveCTokens.MinusId, ObjectiveCTokens.MinusIndex)
    { }
}