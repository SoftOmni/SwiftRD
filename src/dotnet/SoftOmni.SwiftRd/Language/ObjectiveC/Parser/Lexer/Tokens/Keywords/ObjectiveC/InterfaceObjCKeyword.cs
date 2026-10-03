using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class InterfaceObjCKeywordToken : ObjectiveCKeywordToken<InterfaceObjCKeyword>
{
    internal InterfaceObjCKeywordToken()
        : base(ObjectiveCTokens.InterfaceObjCKeywordId, ObjectiveCTokens.InterfaceObjCKeywordIndex)
    { }
}