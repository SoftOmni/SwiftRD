using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class AutoReleasePoolObjCKeywordToken : ObjectiveCKeywordToken<AutoReleasePoolObjCKeyword>
{
    internal AutoReleasePoolObjCKeywordToken()
        : base(ObjectiveCTokens.AutoReleasePoolObjCKeywordId, ObjectiveCTokens.AutoReleasePoolObjCKeywordIndex)
    { }
}