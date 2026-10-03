using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class VolatileKeywordToken : CKeywordToken<VolatileKeyword>
{
    internal VolatileKeywordToken()
        : base(ObjectiveCTokens.VolatileKeywordId, ObjectiveCTokens.VolatileKeywordIndex)
    { }
}