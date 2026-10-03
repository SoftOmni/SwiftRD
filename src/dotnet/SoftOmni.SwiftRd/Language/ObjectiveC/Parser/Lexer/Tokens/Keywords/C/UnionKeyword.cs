using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class UnionKeywordToken : CKeywordToken<UnionKeyword>
{
    internal UnionKeywordToken()
        : base(ObjectiveCTokens.UnionKeywordId, ObjectiveCTokens.UnionKeywordIndex)
    { }
}