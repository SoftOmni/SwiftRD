using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class BridgeTransferObjCArcKeywordToken : ObjectiveCKeywordToken<BridgeTransferObjCArcKeyword>
{
    internal BridgeTransferObjCArcKeywordToken()
        : base(ObjectiveCTokens.BridgeTransferObjCArcKeywordId, ObjectiveCTokens.BridgeTransferObjCArcKeywordIndex)
    { }
}