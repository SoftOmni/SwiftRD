using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class SignedKeywordToken : CKeywordToken<SignedKeyword>
{
    internal SignedKeywordToken()
        : base(ObjectiveCTokens.SignedKeywordId, ObjectiveCTokens.SignedKeywordIndex)
    { }
}