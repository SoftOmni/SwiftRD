using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ReturnStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ReturnKeywordToken : StatementUsableKeywordToken<Return>
{
    internal ReturnKeywordToken()
        : base(Return.Keyword, SwiftTokens.ReturnId, SwiftTokens.ReturnIndex)
    { }
}
