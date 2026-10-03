using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PlusToken : PunctuatorToken<Plus>
{
    internal PlusToken()
        : base(ObjectiveCTokens.PlusId, ObjectiveCTokens.PlusIndex)
    { }
}