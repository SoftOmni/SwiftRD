using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class UnsignedKeywordToken : CKeywordToken<UnsignedKeyword>
{
    internal UnsignedKeywordToken()
        : base(ObjectiveCTokens.UnsignedKeywordId, ObjectiveCTokens.UnsignedKeywordIndex)
    { }
}