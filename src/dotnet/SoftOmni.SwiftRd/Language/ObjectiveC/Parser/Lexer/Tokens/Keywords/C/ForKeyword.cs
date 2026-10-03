using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ForKeywordToken : CKeywordToken<ForKeyword>
{
    internal ForKeywordToken()
        : base(ObjectiveCTokens.ForKeywordId, ObjectiveCTokens.ForKeywordIndex)
    { }
}