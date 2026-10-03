using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class SlashToken : PunctuatorToken<Slash>
{
    internal SlashToken()
        : base(ObjectiveCTokens.SlashId, ObjectiveCTokens.SlashIndex)
    { }
}