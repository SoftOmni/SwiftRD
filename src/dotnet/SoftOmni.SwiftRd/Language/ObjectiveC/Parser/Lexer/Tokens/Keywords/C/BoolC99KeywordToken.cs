using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class BoolC99KeywordToken : CKeywordToken<BoolC99Keyword>
{
    internal BoolC99KeywordToken()
        : base(ObjectiveCTokens.BoolC99KeywordId, ObjectiveCTokens.BoolC99KeywordIndex)
    { }
}
