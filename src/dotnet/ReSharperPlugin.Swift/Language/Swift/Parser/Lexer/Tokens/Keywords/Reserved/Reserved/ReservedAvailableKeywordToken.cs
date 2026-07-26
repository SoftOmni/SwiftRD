using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedAvailableKeywordToken : ReservedKeywordToken<ReservedAvailableKeyword>
{
    internal ReservedAvailableKeywordToken()
        : base(ReservedAvailableKeyword.Keyword, SwiftTokens.ReservedAvailableId, SwiftTokens.ReservedAvailableIndex)
    { }
}