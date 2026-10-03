using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class WhileKeywordToken : CKeywordToken<WhileKeyword>
{
    internal WhileKeywordToken()
        : base(ObjectiveCTokens.WhileKeywordId, ObjectiveCTokens.WhileKeywordIndex)
    { }
}
