using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class HigherThanKeywordToken : ContextSensitiveKeywordToken<HigherThan>
{
    internal HigherThanKeywordToken()
        : base(HigherThan.Keyword, SwiftTokens.HigherThanId, SwiftTokens.HigherThanIndex)
    { }
}
