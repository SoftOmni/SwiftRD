using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class CompatibilityAliasObjCKeywordToken : ObjectiveCKeywordToken<CompatibilityAliasObjCKeyword>
{
    internal CompatibilityAliasObjCKeywordToken()
        : base(ObjectiveCTokens.CompatibilityAliasObjCKeywordId, ObjectiveCTokens.CompatibilityAliasObjCKeywordIndex)
    { }
}