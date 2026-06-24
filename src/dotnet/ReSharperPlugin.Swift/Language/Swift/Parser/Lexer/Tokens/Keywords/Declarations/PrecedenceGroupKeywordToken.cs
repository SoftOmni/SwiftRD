using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class PrecedenceGroupKeywordToken : DeclarationUsableKeywordToken<PrecedenceGroupKeyword>
{
    internal PrecedenceGroupKeywordToken()
        : base(PrecedenceGroupKeyword.Keyword, SwiftTokens.PrecedenceGroupId, SwiftTokens.PrecedenceGroupIndex)
    { }
}