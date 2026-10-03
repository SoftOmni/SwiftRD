using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class LongKeywordToken : CKeywordToken<LongKeyword>
{
    internal LongKeywordToken()
        : base(ObjectiveCTokens.LongKeywordId, ObjectiveCTokens.LongKeywordIndex)
    { }
}