using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class LowerThanKeywordToken : ContextSensitiveKeywordToken<LowerThan>
{
    internal LowerThanKeywordToken()
        : base(LowerThan.Keyword, SwiftTokens.LowerThanId, SwiftTokens.LowerThanIndex)
    { }
}
