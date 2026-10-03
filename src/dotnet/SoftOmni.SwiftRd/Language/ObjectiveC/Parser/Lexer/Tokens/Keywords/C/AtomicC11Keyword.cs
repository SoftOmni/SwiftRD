using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class AtomicC11KeywordToken : C11KeywordToken<AtomicC11Keyword>
{
    internal AtomicC11KeywordToken()
        : base(ObjectiveCTokens.AtomicC11KeywordId, ObjectiveCTokens.AtomicC11KeywordIndex)
    { }
}