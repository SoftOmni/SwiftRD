using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ElseIfDirectiveKeywordToken : ReservedKeywordToken<ElseIfDirective>
{
    internal ElseIfDirectiveKeywordToken()
        : base(ElseIfDirective.Keyword, SwiftTokens.ReservedElseIfId, SwiftTokens.ReservedElseIfIndex)
    { }
}