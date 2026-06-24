using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class AwaitKeywordToken : ExpressionAndTypeUsableKeywordToken<Await>
{
    internal AwaitKeywordToken()
        : base(Await.Keyword, SwiftTokens.AwaitId, SwiftTokens.AwaitIndex)
    { }
}
