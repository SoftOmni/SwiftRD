using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class DefsObjCKeywordToken : ObjectiveCKeywordToken<DefsObjCKeyword>
{
    internal DefsObjCKeywordToken()
        : base(ObjectiveCTokens.DefsObjCKeywordId, ObjectiveCTokens.DefsObjCKeywordIndex)
    { }
}