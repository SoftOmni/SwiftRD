using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class RestrictKeywordToken : CKeywordToken<RestrictKeyword>
{
    internal RestrictKeywordToken()
        : base(ObjectiveCTokens.RestrictKeywordId, ObjectiveCTokens.RestrictKeywordIndex)
    { }
}