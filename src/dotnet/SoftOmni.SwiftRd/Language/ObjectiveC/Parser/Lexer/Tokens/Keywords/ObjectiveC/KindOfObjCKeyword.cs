using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class KindOfObjCKeywordToken : ObjectiveCKeywordToken<KindOfObjCKeyword>
{
    internal KindOfObjCKeywordToken()
        : base(ObjectiveCTokens.KindOfObjCKeywordId, ObjectiveCTokens.KindOfObjCKeywordIndex)
    { }
}