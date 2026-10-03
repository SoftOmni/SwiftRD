using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class QuestionMarkToken : PunctuatorToken<QuestionMark>
{
    internal QuestionMarkToken()
        : base(ObjectiveCTokens.QuestionMarkId, ObjectiveCTokens.QuestionMarkIndex)
    { }
}
