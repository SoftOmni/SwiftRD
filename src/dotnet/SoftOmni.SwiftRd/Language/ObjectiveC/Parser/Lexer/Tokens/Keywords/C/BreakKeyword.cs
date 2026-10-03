using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class BreakKeywordToken : CKeywordToken<BreakKeyword>
{
    internal BreakKeywordToken()
        : base(ObjectiveCTokens.BreakKeywordId, ObjectiveCTokens.BreakKeywordIndex)
    { }
}
