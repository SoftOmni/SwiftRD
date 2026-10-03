using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class CaseKeywordToken : CKeywordToken<CaseKeyword>
{
    internal CaseKeywordToken()
        : base(ObjectiveCTokens.CaseKeywordId, ObjectiveCTokens.CaseKeywordIndex)
    { }
}
