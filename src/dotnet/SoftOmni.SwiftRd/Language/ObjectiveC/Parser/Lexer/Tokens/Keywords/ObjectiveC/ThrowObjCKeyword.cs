using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class ThrowObjCKeywordToken : ObjectiveCKeywordToken<ThrowObjCKeyword>
{
    internal ThrowObjCKeywordToken()
        : base(ObjectiveCTokens.ThrowObjCKeywordId, ObjectiveCTokens.ThrowObjCKeywordIndex)
    { }
}