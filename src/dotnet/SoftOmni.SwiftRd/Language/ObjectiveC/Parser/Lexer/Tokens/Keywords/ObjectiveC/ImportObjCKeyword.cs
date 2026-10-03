using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class ImportObjCKeywordToken : ObjectiveCKeywordToken<ImportObjCKeyword>
{
    internal ImportObjCKeywordToken()
        : base(ObjectiveCTokens.ImportObjCKeywordId, ObjectiveCTokens.ImportObjCKeywordIndex)
    { }
}