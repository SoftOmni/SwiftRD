using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class OperatorKeywordToken : DeclarationUsableKeywordToken<OperatorKeyword>
{
    internal OperatorKeywordToken()
        : base(OperatorKeyword.Keyword, SwiftTokens.OperatorId, SwiftTokens.OperatorIndex)
    { }
}
