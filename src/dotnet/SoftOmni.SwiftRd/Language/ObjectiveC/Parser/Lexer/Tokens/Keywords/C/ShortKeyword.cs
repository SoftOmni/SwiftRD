using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ShortKeywordToken : CKeywordToken<ShortKeyword>
{
    internal ShortKeywordToken()
        : base(ObjectiveCTokens.ShortKeywordId, ObjectiveCTokens.ShortKeywordIndex)
    { }
}