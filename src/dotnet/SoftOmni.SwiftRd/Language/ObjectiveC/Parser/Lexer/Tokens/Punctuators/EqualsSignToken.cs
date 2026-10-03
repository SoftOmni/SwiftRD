using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class EqualsSignToken : PunctuatorToken<EqualsSign>
{
    internal EqualsSignToken()
        : base(ObjectiveCTokens.EqualsSignId, ObjectiveCTokens.EqualsSignIndex)
    { }
}