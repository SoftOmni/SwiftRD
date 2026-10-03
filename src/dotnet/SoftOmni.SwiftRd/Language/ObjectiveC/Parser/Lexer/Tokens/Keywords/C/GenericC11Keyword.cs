using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class GenericC11KeywordToken : C11KeywordToken<GenericC11Keyword>
{
    internal GenericC11KeywordToken()
        : base(ObjectiveCTokens.GenericC11KeywordId, ObjectiveCTokens.GenericC11KeywordIndex)
    { }
}
