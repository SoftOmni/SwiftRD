using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ExclamationMarkEqualsSignToken : PunctuatorToken<ExclamationMarkEqualsSign>
{
    internal ExclamationMarkEqualsSignToken()
        : base(ObjectiveCTokens.ExclamationMarkEqualsSignId, ObjectiveCTokens.ExclamationMarkEqualsSignIndex)
    { }
}