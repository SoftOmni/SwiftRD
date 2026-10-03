using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningParenthesisToken : PunctuatorToken<OpeningParenthesis>
{
    internal OpeningParenthesisToken()
        : base(ObjectiveCTokens.OpeningParenthesisId, ObjectiveCTokens.OpeningParenthesisIndex)
    { }
}
