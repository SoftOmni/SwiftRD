using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class PropertyObjCKeywordToken : ObjectiveCKeywordToken<PropertyObjCKeyword>
{
    internal PropertyObjCKeywordToken()
        : base(ObjectiveCTokens.PropertyObjCKeywordId, ObjectiveCTokens.PropertyObjCKeywordIndex)
    { }
}