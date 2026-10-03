using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleHashtagToken : PunctuatorToken<DoubleHashtag>
{
    internal DoubleHashtagToken()
        : base(ObjectiveCTokens.DoubleHashtagId, ObjectiveCTokens.DoubleHashtagIndex)
    { }
}