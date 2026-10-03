using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class SizeofKeywordToken : CKeywordToken<SizeofKeyword>
{
    internal SizeofKeywordToken()
        : base(ObjectiveCTokens.SizeofKeywordId, ObjectiveCTokens.SizeofKeywordIndex)
    { }
}