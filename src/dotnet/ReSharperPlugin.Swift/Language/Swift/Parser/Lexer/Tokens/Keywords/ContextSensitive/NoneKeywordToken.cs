using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class NoneKeywordToken : ContextSensitiveKeywordToken<None>
{
    internal NoneKeywordToken()
        : base(None.Keyword, SwiftTokens.NoneId, SwiftTokens.NoneIndex)
    { }
}
