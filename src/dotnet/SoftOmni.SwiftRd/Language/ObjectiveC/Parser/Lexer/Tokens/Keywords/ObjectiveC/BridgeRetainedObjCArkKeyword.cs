using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class BridgeRetainedObjCArcKeywordToken : ObjectiveCKeywordToken<BridgeRetainedObjCArcKeyword>
{
    internal BridgeRetainedObjCArcKeywordToken()
        : base(ObjectiveCTokens.BridgeRetainedObjCArcKeywordId, ObjectiveCTokens.BridgeRetainedObjCArcKeywordIndex)
    { }
}