using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ThreadLocalC11KeywordToken : C11KeywordToken<ThreadLocalC11Keyword>
{
    internal ThreadLocalC11KeywordToken()
        : base(ObjectiveCTokens.ThreadLocalC11KeywordId, ObjectiveCTokens.ThreadLocalC11KeywordIndex)
    { }
}
