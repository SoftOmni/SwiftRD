using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class SynchronizedObjCKeywordToken : ObjectiveCKeywordToken<SynchronizedObjCKeyword>
{
    internal SynchronizedObjCKeywordToken()
        : base(ObjectiveCTokens.SynchronizedObjCKeywordId, ObjectiveCTokens.SynchronizedObjCKeywordIndex)
    { }
}