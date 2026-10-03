using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningSquareBracketToken : PunctuatorToken<OpeningSquareBracket>
{
    internal OpeningSquareBracketToken()
        : base(ObjectiveCTokens.OpeningSquareBracketId, ObjectiveCTokens.OpeningSquareBracketIndex)
    { }
}
