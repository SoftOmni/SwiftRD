using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class IntKeywordToken : CKeywordToken<IntKeyword>
{
    internal IntKeywordToken()
        : base(ObjectiveCTokens.IntKeywordId, ObjectiveCTokens.IntKeywordIndex)
    { }
}