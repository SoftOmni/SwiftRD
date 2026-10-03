using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class BridgeRetainObjCArcKeywordToken : ObjectiveCKeywordToken<BridgeRetainObjCArcKeyword>
{
    internal BridgeRetainObjCArcKeywordToken()
        : base(ObjectiveCTokens.BridgeRetainObjCArcKeywordId, ObjectiveCTokens.BridgeRetainObjCArcKeywordIndex)
    { }
}