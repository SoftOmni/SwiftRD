using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class NoreturnC11KeywordToken : C11KeywordToken<NoreturnC11Keyword>
{
    internal NoreturnC11KeywordToken()
        : base(ObjectiveCTokens.NoreturnC11KeywordId, ObjectiveCTokens.NoreturnC11KeywordIndex)
    { }
}