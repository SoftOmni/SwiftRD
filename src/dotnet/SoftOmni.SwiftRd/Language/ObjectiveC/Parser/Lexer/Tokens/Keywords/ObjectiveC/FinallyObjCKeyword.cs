using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class FinallyObjCKeywordToken : ObjectiveCKeywordToken<FinallyObjCKeyword>
{
    internal FinallyObjCKeywordToken()
        : base(ObjectiveCTokens.FinallyObjCKeywordId, ObjectiveCTokens.FinallyObjCKeywordIndex)
    { }
}