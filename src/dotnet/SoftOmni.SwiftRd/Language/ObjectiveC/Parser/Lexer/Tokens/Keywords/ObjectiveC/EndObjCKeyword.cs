using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class EndObjCKeywordToken : ObjectiveCKeywordToken<EndObjCKeyword>
{
    internal EndObjCKeywordToken()
        : base(ObjectiveCTokens.EndObjCKeywordId, ObjectiveCTokens.EndObjCKeywordIndex)
    { }
}