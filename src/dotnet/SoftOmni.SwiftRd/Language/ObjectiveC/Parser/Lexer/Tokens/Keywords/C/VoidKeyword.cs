using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class VoidKeywordToken : CKeywordToken<VoidKeyword>
{
    internal VoidKeywordToken()
        : base(ObjectiveCTokens.VoidKeywordId, ObjectiveCTokens.VoidKeywordIndex)
    { }
}