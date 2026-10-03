using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningAngleBracketColonToken : PunctuatorToken<OpeningAngleBracketColon>
{
    internal OpeningAngleBracketColonToken()
        : base(ObjectiveCTokens.OpeningAngleBracketColonId, ObjectiveCTokens.OpeningAngleBracketColonIndex)
    { }
}