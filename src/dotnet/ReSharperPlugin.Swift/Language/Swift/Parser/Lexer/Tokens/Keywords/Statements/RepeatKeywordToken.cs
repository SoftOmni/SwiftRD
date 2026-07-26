using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public class RepeatKeywordToken : StatementUsableKeywordToken<Repeat>
{
    internal RepeatKeywordToken()
        : base(Repeat.Keyword, SwiftTokens.RepeatId, SwiftTokens.RepeatIndex)
    { }
}

