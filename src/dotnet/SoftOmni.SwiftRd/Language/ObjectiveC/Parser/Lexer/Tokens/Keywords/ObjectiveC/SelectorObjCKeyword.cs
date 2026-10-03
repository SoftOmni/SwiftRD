using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class SelectorObjCKeywordToken : ObjectiveCKeywordToken<SelectorObjCKeyword>
{
    internal SelectorObjCKeywordToken()
        : base(ObjectiveCTokens.SelectorObjCKeywordId, ObjectiveCTokens.SelectorObjCKeywordIndex)
    { }
}