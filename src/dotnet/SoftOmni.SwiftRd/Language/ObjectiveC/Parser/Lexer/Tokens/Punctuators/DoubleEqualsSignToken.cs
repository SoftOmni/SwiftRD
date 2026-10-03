using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleEqualsSignToken : PunctuatorToken<DoubleEqualsSign>
{
    internal DoubleEqualsSignToken()
        : base(ObjectiveCTokens.DoubleEqualsSignId, ObjectiveCTokens.DoubleEqualsSignIndex)
    { }
}
