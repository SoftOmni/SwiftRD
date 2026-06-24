using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class SomeKeywordToken : ContextSensitiveKeywordToken<Some>
{
    internal SomeKeywordToken()
        : base(Some.Keyword, SwiftTokens.SomeId, SwiftTokens.SomeIndex)
    { }
}