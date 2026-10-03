using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class IfKeywordToken : CKeywordToken<IfKeyword>
{
    internal IfKeywordToken()
        : base(ObjectiveCTokens.IfKeywordId, ObjectiveCTokens.IfKeywordIndex)
    { }
}