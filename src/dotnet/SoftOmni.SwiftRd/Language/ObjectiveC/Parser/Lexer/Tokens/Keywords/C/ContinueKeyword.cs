using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ContinueKeywordToken : CKeywordToken<ContinueKeyword>
{
    internal ContinueKeywordToken()
        : base(ObjectiveCTokens.ContinueKeywordId, ObjectiveCTokens.ContinueKeywordIndex)
    { }
}
