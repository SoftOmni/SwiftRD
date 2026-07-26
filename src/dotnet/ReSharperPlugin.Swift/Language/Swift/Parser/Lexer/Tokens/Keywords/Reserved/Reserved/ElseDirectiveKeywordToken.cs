using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ElseDirectiveKeywordToken : ReservedKeywordToken<ElseDirective>
{
    internal ElseDirectiveKeywordToken()
        : base(ElseDirective.Keyword, SwiftTokens.ReservedElseId, SwiftTokens.ReservedElseIndex)
    { }
}
