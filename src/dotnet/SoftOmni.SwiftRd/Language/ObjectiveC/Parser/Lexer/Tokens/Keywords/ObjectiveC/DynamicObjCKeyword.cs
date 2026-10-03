using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class DynamicObjCKeywordToken : ObjectiveCKeywordToken<DynamicObjCKeyword>
{
    internal DynamicObjCKeywordToken()
        : base(ObjectiveCTokens.DynamicObjCKeywordId, ObjectiveCTokens.DynamicObjCKeywordIndex)
    { }
}