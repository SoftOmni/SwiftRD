using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningAngleBracketToken : PunctuatorToken<OpeningAngleBracket>
{
    internal OpeningAngleBracketToken()
        : base(ObjectiveCTokens.OpeningAngleBracketId, ObjectiveCTokens.OpeningAngleBracketIndex)
    { }
}
