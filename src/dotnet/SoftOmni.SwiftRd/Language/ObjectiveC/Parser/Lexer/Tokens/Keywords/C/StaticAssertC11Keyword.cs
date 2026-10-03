using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class StaticAssertC11KeywordToken : C11KeywordToken<StaticAssertC11Keyword>
{
    internal StaticAssertC11KeywordToken()
        : base(ObjectiveCTokens.StaticAssertC11KeywordId, ObjectiveCTokens.StaticAssertC11KeywordIndex)
    { }
}