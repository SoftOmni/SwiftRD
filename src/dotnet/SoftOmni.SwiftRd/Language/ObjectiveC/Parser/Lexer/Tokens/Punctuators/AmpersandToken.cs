using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class AmpersandToken : PunctuatorToken<Ampersand>
{
    internal AmpersandToken()
        : base(Ampersand.Value, ObjectiveCTokens.AmpersandIndex)
    { }
}
