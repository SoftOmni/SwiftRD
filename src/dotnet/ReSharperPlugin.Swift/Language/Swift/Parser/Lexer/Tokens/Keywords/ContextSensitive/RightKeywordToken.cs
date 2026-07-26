using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class RightKeywordToken : ContextSensitiveKeywordToken<Right>
{
    internal RightKeywordToken()
        : base(Right.Keyword, SwiftTokens.RightId, SwiftTokens.RightIndex)
    { }
}
