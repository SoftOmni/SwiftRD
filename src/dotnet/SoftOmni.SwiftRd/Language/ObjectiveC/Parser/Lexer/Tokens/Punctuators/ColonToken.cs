using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ColonToken : PunctuatorToken<Colon>
{
    internal ColonToken()
        : base(ObjectiveCTokens.ColonId, ObjectiveCTokens.ColonIndex)
    { }
}