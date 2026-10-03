using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ClosingSquareBracketToken : PunctuatorToken<ClosingSquareBracket>
{
    internal ClosingSquareBracketToken()
        : base(ObjectiveCTokens.ClosingSquareBracketId, ObjectiveCTokens.ClosingSquareBracketIndex)
    { }
}
