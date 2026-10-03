using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class AlignasC11KeywordToken : C11KeywordToken<AlignasC11Keyword>
{
    internal AlignasC11KeywordToken()
        : base(ObjectiveCTokens.AlignasC11KeywordId, ObjectiveCTokens.AlignasC11KeywordIndex)
    { }
}
