using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ElseKeywordToken : CKeywordToken<ElseKeyword>
{
    internal ElseKeywordToken()
        : base(ObjectiveCTokens.ElseKeywordId, ObjectiveCTokens.ElseKeywordIndex)
    { }
}