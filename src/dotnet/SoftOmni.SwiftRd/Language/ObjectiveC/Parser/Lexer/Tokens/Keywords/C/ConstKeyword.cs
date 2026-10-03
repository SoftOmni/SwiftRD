using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ConstKeywordToken : CKeywordToken<ConstKeyword>
{
    internal ConstKeywordToken()
        : base(ObjectiveCTokens.ConstKeywordId, ObjectiveCTokens.ConstKeywordIndex)
    { }
}
