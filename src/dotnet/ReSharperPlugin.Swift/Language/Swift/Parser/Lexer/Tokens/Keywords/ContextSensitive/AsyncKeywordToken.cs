using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class AsyncKeywordToken : ContextSensitiveKeywordToken<Async>
{
    internal AsyncKeywordToken()
        : base(Async.Keyword, SwiftTokens.AsyncId, SwiftTokens.AsyncIndex)
    { }
}
