using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningAngleBracketPercentageSignToken : PunctuatorToken<OpeningAngleBracketPercentageSign>
{
    internal OpeningAngleBracketPercentageSignToken()
        : base(ObjectiveCTokens.OpeningAngleBracketPercentageSignId, ObjectiveCTokens.OpeningAngleBracketPercentageSignIndex)
    { }
}