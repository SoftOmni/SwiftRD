using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class SlashEqualsSignToken : PunctuatorToken<SlashEqualsSign>
{
    internal SlashEqualsSignToken()
        : base(ObjectiveCTokens.SlashEqualsSignId, ObjectiveCTokens.SlashEqualsSignIndex)
    { }
}