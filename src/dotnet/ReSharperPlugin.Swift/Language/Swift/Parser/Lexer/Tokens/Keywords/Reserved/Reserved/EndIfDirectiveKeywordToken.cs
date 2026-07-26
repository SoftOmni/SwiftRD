using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class EndIfDirectiveKeywordToken : ReservedKeywordToken<EndIfDirective>
{
    internal EndIfDirectiveKeywordToken()
        : base(EndIfDirective.Keyword, SwiftTokens.ReservedEndIfId, SwiftTokens.ReservedEndIfIndex)
    { }
}
