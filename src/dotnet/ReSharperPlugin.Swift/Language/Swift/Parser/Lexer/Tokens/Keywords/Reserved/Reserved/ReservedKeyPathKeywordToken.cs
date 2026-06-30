using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedKeyPathKeywordToken : ReservedKeywordToken<KeyPathKeyword>
{
    internal ReservedKeyPathKeywordToken()
        : base(KeyPathKeyword.Keyword, SwiftTokens.ReservedKeyPathId, SwiftTokens.ReservedKeyPathIndex)
    { }
}
