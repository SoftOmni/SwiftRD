using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class CaretEqualsSignToken : PunctuatorToken<CaretEqualsSign>
{
    internal CaretEqualsSignToken()
        : base(ObjectiveCTokens.CaretEqualsSignId, ObjectiveCTokens.CaretEqualsSignIndex)
    { }
}