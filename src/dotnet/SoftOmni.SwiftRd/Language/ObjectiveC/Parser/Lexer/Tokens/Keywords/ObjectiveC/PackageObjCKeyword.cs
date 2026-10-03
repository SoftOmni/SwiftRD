using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class PackageObjCKeywordToken : ObjectiveCKeywordToken<PackageObjCKeyword>
{
    internal PackageObjCKeywordToken()
        : base(ObjectiveCTokens.PackageObjCKeywordId, ObjectiveCTokens.PackageObjCKeywordIndex)
    { }
}