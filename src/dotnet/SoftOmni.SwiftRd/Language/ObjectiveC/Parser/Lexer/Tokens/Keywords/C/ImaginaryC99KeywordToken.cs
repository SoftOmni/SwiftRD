using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ImaginaryC99KeywordToken : CKeywordToken<ImaginaryC99Keyword>
{
    internal ImaginaryC99KeywordToken()
        : base(ObjectiveCTokens.ImaginaryC99KeywordId, ObjectiveCTokens.ImaginaryC99KeywordIndex)
    { }
}
