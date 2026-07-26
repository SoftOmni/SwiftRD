using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class LeftKeywordToken : ContextSensitiveKeywordToken<Left>
{
    internal LeftKeywordToken()
        : base(Left.Keyword, SwiftTokens.LeftId, SwiftTokens.LeftIndex)
    { }
}
