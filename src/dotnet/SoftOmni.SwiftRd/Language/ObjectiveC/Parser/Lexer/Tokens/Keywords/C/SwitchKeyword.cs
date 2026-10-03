using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class SwitchKeywordToken : CKeywordToken<SwitchKeyword>
{
    internal SwitchKeywordToken()
        : base(ObjectiveCTokens.SwitchKeywordId, ObjectiveCTokens.SwitchKeywordIndex)
    { }
}