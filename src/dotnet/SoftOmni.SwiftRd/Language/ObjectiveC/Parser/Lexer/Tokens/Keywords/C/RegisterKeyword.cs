using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class RegisterKeywordToken : CKeywordToken<RegisterKeyword>
{
    internal RegisterKeywordToken()
        : base(ObjectiveCTokens.RegisterKeywordId, ObjectiveCTokens.RegisterKeywordIndex)
    { }
}