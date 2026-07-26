using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class WhereKeywordToken : StatementUsableKeywordToken<Where>
{
    internal WhereKeywordToken()
        : base(Where.Keyword, SwiftTokens.WhereId, SwiftTokens.WhereIndex)
    { }
}