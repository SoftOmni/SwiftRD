using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PlusEqualsSignToken : PunctuatorToken<PlusEqualsSign>
{
    internal PlusEqualsSignToken()
        : base(ObjectiveCTokens.PlusEqualsSignId, ObjectiveCTokens.PlusEqualsSignIndex)
    { }
}