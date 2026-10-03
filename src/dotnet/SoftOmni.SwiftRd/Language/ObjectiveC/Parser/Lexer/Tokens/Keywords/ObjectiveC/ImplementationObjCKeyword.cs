using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class ImplementationObjCKeywordToken : ObjectiveCKeywordToken<ImplementationObjCKeyword>
{
    internal ImplementationObjCKeywordToken()
        : base(ObjectiveCTokens.ImplementationObjCKeywordId, ObjectiveCTokens.ImplementationObjCKeywordIndex)
    { }
}