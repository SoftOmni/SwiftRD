using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class ElseKeywordToken : StatementUsableKeywordToken<Else>
{
    internal ElseKeywordToken()
        : base(Else.Keyword, SwiftTokens.ElseId, SwiftTokens.ElseIndex)
    { }
}
