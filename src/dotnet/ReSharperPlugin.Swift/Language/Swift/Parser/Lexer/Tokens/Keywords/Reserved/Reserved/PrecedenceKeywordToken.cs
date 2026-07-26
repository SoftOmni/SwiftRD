using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PrecedenceKeywordToken : ReservedKeywordToken<Precedence>
{
    internal PrecedenceKeywordToken()
        : base(Precedence.Keyword, SwiftTokens.PrecedenceId, SwiftTokens.PrecedenceIndex)
    { }
}
