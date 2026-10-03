using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleClosingAngleBracketToken : PunctuatorToken<DoubleClosingAngleBracket>
{
    internal DoubleClosingAngleBracketToken()
        : base(ObjectiveCTokens.DoubleClosingAngleBracketId, ObjectiveCTokens.DoubleClosingAngleBracketIndex)
    { }
}