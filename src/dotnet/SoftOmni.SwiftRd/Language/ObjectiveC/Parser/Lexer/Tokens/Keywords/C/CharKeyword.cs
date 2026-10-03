using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class CharKeywordToken : CKeywordToken<CharKeyword>
{
    internal CharKeywordToken()
        : base(ObjectiveCTokens.CharKeywordId, ObjectiveCTokens.CharKeywordIndex)
    { }
}