using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PlusPlusToken : PunctuatorToken<PlusPlus>
{
    internal PlusPlusToken()
        : base(ObjectiveCTokens.PlusPlusId, ObjectiveCTokens.PlusPlusIndex)
    { }
}