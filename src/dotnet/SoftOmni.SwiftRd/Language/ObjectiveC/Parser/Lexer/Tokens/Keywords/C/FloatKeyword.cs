using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class FloatKeywordToken : CKeywordToken<FloatKeyword>
{
    internal FloatKeywordToken()
        : base(ObjectiveCTokens.FloatKeywordId, ObjectiveCTokens.FloatKeywordIndex)
    { }
}