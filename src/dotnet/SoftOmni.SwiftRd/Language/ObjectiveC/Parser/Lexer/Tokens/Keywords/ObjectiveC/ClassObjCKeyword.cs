using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class ClassObjCKeywordToken : ObjectiveCKeywordToken<ClassObjCKeyword>
{
    internal ClassObjCKeywordToken()
        : base(ObjectiveCTokens.ClassObjCKeywordId, ObjectiveCTokens.ClassObjCKeywordIndex)
    { }
}