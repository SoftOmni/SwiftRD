using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class PublicObjCKeywordToken : ObjectiveCKeywordToken<PublicObjCKeyword>
{
    internal PublicObjCKeywordToken()
        : base(ObjectiveCTokens.PublicObjCKeywordId, ObjectiveCTokens.PublicObjCKeywordIndex)
    { }
}