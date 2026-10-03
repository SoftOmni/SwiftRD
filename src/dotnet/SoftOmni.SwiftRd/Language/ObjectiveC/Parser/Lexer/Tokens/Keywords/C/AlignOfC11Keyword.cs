using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class AlignOfC11KeywordToken : C11KeywordToken<AlignOfC11Keyword>
{
    internal AlignOfC11KeywordToken()
        : base(ObjectiveCTokens.AlignOfC11KeywordId, ObjectiveCTokens.AlignOfC11KeywordIndex)
    { }
}