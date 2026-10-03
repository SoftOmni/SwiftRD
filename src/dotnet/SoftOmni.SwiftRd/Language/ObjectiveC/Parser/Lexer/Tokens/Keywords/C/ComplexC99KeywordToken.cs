using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public sealed class ComplexC99KeywordToken : CKeywordToken<ComplexC99Keyword>
{
    internal ComplexC99KeywordToken()
        : base(ObjectiveCTokens.ComplexC99KeywordId, ObjectiveCTokens.ComplexC99KeywordIndex)
    { }
}