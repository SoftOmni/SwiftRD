using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class AmpersandEqualsSignToken : PunctuatorToken<AmpersandEqualsSign>
{
    internal AmpersandEqualsSignToken()
        : base(ObjectiveCTokens.AmpersandEqualsSignId, ObjectiveCTokens.AmpersandEqualsSignIndex)
    { }
}