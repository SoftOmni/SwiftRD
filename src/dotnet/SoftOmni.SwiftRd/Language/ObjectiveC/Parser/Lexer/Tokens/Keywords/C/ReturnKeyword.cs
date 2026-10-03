using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ReturnKeywordToken : CKeywordToken<ReturnKeyword>
{
    internal ReturnKeywordToken()
        : base(ObjectiveCTokens.ReturnKeywordId, ObjectiveCTokens.ReturnKeywordIndex)
    { }
}