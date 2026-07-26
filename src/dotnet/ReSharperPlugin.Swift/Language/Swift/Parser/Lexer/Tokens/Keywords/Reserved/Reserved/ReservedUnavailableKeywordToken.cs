using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedUnavailableKeywordToken : ReservedKeywordToken<ReservedUnavailableKeyword>
{
    internal ReservedUnavailableKeywordToken()
        : base(ReservedUnavailableKeyword.Keyword, SwiftTokens.ReservedUnavailableId, SwiftTokens.ReservedUnavailableIndex)
    { }
}
