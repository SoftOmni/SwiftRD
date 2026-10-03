using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class CovariantObjCKeywordToken : ObjectiveCKeywordToken<CovariantObjCKeyword>
{
    internal CovariantObjCKeywordToken()
        : base(ObjectiveCTokens.CovariantObjCKeywordId, ObjectiveCTokens.CovariantObjCKeywordIndex)
    { }
}