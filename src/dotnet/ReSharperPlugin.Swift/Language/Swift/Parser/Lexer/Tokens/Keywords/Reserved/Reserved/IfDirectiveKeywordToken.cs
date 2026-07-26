using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedIfKeywordToken : ReservedKeywordToken<IfDirective>
{
    internal ReservedIfKeywordToken()
        : base("#if", SwiftTokens.ReservedIfId, SwiftTokens.ReservedIfIndex)
    { }
}
