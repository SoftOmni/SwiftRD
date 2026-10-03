using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class MinusEqualsSignToken : PunctuatorToken<MinusEqualsSign>
{
    internal MinusEqualsSignToken()
        : base(ObjectiveCTokens.MinusEqualsSignId, ObjectiveCTokens.MinusEqualsSignIndex)
    { }
}