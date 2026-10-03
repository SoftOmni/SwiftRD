using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class DoubleKeywordToken : CKeywordToken<DoubleKeyword>
{
    internal DoubleKeywordToken()
        : base(ObjectiveCTokens.DoubleKeywordId, ObjectiveCTokens.DoubleKeywordIndex)
    { }
}