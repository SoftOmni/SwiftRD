using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class EnumKeywordToken : CKeywordToken<EnumKeyword>
{
    internal EnumKeywordToken()
        : base(ObjectiveCTokens.EnumKeywordId, ObjectiveCTokens.EnumKeywordIndex)
    { }
}