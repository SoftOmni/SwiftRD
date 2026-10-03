using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class DefaultKeywordToken : CKeywordToken<DefaultKeyword>
{
    internal DefaultKeywordToken()
        : base(ObjectiveCTokens.DefaultKeywordId, ObjectiveCTokens.DefaultKeywordIndex)
    { }
}