using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ExternKeywordToken : CKeywordToken<ExternKeyword>
{
    internal ExternKeywordToken()
        : base(ObjectiveCTokens.ExternKeywordId, ObjectiveCTokens.ExternKeywordIndex)
    { }
}