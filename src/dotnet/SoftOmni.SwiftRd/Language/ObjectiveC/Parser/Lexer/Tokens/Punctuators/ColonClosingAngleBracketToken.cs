using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ColonClosingAngleBracketToken : PunctuatorToken<ColonClosingAngleBracket>
{
    internal ColonClosingAngleBracketToken()
        : base(ObjectiveCTokens.ColonClosingAngleBracketId, ObjectiveCTokens.ColonClosingAngleBracketIndex)
    { }
}