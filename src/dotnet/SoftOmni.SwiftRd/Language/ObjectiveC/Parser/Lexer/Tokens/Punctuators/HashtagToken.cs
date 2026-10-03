using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class HashtagToken : PunctuatorToken<Hashtag>
{
    internal HashtagToken()
        : base(ObjectiveCTokens.HashtagId, ObjectiveCTokens.HashtagIndex)
    { }
}