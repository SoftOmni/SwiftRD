using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class SemicolonToken : PunctuatorToken<Semicolon>
{
    internal SemicolonToken()
        : base(ObjectiveCTokens.SemicolonId, ObjectiveCTokens.SemicolonIndex)
    { }
}