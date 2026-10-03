using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class GotoKeywordToken : CKeywordToken<GotoKeyword>
{
    internal GotoKeywordToken()
        : base(ObjectiveCTokens.GotoKeywordId, ObjectiveCTokens.GotoKeywordIndex)
    { }
}