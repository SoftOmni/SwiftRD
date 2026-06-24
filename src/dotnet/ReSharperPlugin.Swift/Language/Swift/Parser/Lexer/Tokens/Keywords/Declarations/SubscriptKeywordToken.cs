using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class SubscriptKeywordToken : DeclarationUsableKeywordToken<SubscriptKeyword>
{
    internal SubscriptKeywordToken()
        : base(SubscriptKeyword.Keyword, SwiftTokens.SubscriptId, SwiftTokens.SubscriptIndex)
    { }
}
