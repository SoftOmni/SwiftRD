using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class InlineKeywordToken : CKeywordToken<InlineKeyword>
{
    internal InlineKeywordToken()
        : base(ObjectiveCTokens.InlineKeywordId, ObjectiveCTokens.InlineKeywordIndex)
    { }
}