using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ArrowToken : PunctuatorToken<Arrow>
{
    internal ArrowToken()
        : base(ObjectiveCTokens.ArrowId, ObjectiveCTokens.ArrowIndex)
    { }
}