using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedSourceLocationKeywordToken : ReservedKeywordToken<ReservedSourceLocationKeyword>
{
    internal ReservedSourceLocationKeywordToken()
        : base(ReservedSourceLocationKeyword.Keyword, SwiftTokens.ReservedSourceLocationId, SwiftTokens.ReservedSourceLocationIndex)
    { }
}