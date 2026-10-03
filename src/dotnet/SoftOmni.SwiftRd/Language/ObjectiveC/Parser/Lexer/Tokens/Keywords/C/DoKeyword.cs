using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class DoKeywordToken : CKeywordToken<DoKeyword>
{
    internal DoKeywordToken()
        : base(ObjectiveCTokens.DoKeywordId, ObjectiveCTokens.DoKeywordIndex)
    { }
}
