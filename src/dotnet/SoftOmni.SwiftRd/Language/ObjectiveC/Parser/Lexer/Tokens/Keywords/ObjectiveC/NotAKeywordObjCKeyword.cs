using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class NotAKeywordObjCKeywordToken : ObjectiveCKeywordToken<NotAKeywordObjCKeyword>
{
    internal NotAKeywordObjCKeywordToken()
        : base(ObjectiveCTokens.NotAKeywordObjCKeywordId, ObjectiveCTokens.NotAKeywordObjCKeywordIndex)
    { }
}