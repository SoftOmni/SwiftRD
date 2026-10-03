using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class OptionalObjCKeywordToken : ObjectiveCKeywordToken<OptionalObjCKeyword>
{
    internal OptionalObjCKeywordToken()
        : base(ObjectiveCTokens.OptionalObjCKeywordId, ObjectiveCTokens.OptionalObjCKeywordIndex)
    { }
}