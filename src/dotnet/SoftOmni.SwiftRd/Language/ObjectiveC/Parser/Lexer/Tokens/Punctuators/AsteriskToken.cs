using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class AsteriskToken : PunctuatorToken<Asterisk>
{
    internal AsteriskToken()
        : base(ObjectiveCTokens.AsteriskId, ObjectiveCTokens.AsteriskIndex)
    { }
}