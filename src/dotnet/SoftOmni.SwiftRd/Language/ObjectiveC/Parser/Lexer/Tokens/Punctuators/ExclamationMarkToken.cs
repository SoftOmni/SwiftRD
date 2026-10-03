using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ExclamationMarkToken : PunctuatorToken<ExclamationMark>
{
    internal ExclamationMarkToken()
        : base(ObjectiveCTokens.ExclamationMarkId, ObjectiveCTokens.ExclamationMarkIndex)
    { }
}