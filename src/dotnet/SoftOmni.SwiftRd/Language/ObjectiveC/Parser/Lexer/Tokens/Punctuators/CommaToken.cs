using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CommaToken : PunctuatorToken<Comma>
{
    internal CommaToken()
        : base(ObjectiveCTokens.CommaId, ObjectiveCTokens.CommaIndex)
    { }
}