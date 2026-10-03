using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleOpeningAngleBracketToken : PunctuatorToken<DoubleOpeningAngleBracket>
{
    internal DoubleOpeningAngleBracketToken()
        : base(ObjectiveCTokens.DoubleOpeningAngleBracketId, ObjectiveCTokens.DoubleOpeningAngleBracketIndex)
    { }
}