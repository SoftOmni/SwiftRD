using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ClosingAngleBracketToken : PunctuatorToken<ClosingAngleBracket>
{
    internal ClosingAngleBracketToken()
        : base(ObjectiveCTokens.ClosingAngleBracketId, ObjectiveCTokens.ClosingAngleBracketIndex)
    { }
}
