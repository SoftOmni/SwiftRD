using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningCurlyBraceToken : PunctuatorToken<OpeningCurlyBrace>
{
    internal OpeningCurlyBraceToken()
        : base(ObjectiveCTokens.OpeningCurlyBraceId, ObjectiveCTokens.OpeningCurlyBraceIndex)
    { }
}
