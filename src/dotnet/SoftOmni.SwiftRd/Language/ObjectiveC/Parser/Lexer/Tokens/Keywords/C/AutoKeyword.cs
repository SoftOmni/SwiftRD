using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class AutoKeywordToken : CKeywordToken<AutoKeyword>
{
    internal AutoKeywordToken()
        : base(ObjectiveCTokens.AutoKeywordId, ObjectiveCTokens.AutoKeywordIndex)
    { }
}
