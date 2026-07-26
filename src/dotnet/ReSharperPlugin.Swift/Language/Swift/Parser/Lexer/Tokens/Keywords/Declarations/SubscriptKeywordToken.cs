using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class SubscriptKeywordToken : DeclarationUsableKeywordToken<Subscript>
{
    internal SubscriptKeywordToken()
        : base(Subscript.Keyword, SwiftTokens.SubscriptId, SwiftTokens.SubscriptIndex)
    { }
}
