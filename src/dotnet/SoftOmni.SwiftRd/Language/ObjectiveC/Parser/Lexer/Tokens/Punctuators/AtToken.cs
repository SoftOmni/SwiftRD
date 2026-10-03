using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class AtToken : PunctuatorToken<At>
{
    internal AtToken()
        : base(ObjectiveCTokens.AtId, ObjectiveCTokens.AtIndex)
    { }
}