using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class BorrowingKeywordToken : DeclarationUsableKeywordToken<Borrowing>
{ 
    internal BorrowingKeywordToken()
        : base(Borrowing.Keyword, SwiftTokens.BorrowingId, SwiftTokens.BorrowingIndex)
    { }
}