using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ClosingCurlyBraceToken : PunctuatorToken<ClosingCurlyBrace>
{
    internal ClosingCurlyBraceToken()
        : base(ObjectiveCTokens.ClosingCurlyBraceId, ObjectiveCTokens.ClosingCurlyBraceIndex)
    { }
}
