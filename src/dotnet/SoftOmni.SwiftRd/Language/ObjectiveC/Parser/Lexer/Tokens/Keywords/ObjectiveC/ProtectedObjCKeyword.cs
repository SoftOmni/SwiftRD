using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class ProtectedObjCKeywordToken : ObjectiveCKeywordToken<ProtectedObjCKeyword>
{
    internal ProtectedObjCKeywordToken()
        : base(ObjectiveCTokens.ProtectedObjCKeywordId, ObjectiveCTokens.ProtectedObjCKeywordIndex)
    { }
}