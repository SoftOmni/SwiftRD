using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ClosingParenthesisToken : PunctuatorToken<ClosingParenthesis>
{
    internal ClosingParenthesisToken()
        : base(ObjectiveCTokens.ClosingParenthesisId, ObjectiveCTokens.ClosingParenthesisIndex)
    { }
}
