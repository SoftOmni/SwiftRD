using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class IfDirectiveKeywordToken : ReservedKeywordToken<IfDirective>
{
    internal IfDirectiveKeywordToken()
        : base(IfDirective.Keyword, SwiftTokens.ReservedIfId, SwiftTokens.ReservedIfIndex)
    { }
}
