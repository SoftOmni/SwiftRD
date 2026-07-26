using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class AssociativityKeywordToken : ContextSensitiveKeywordToken<Associativity>
{
    internal AssociativityKeywordToken()
        : base(Associativity.Keyword, SwiftTokens.AssociativityId, SwiftTokens.AssociativityIndex)
    { }
}
