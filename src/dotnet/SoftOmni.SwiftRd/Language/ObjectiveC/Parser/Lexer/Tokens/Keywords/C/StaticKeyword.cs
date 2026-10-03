using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class StaticKeywordToken : CKeywordToken<StaticKeyword>
{
    internal StaticKeywordToken()
        : base(ObjectiveCTokens.StaticKeywordId, ObjectiveCTokens.StaticKeywordIndex)
    { }
}