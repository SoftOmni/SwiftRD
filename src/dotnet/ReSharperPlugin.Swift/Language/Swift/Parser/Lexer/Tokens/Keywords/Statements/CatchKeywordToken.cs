using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class CatchKeywordToken : StatementUsableKeywordToken<Catch>
{
    internal CatchKeywordToken()
        : base(Catch.Keyword, SwiftTokens.CatchId, SwiftTokens.CatchIndex)
    { }
}