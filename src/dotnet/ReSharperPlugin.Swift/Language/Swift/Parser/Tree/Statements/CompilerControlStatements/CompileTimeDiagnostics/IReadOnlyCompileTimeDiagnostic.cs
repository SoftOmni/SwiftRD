using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public interface IReadOnlyCompileTimeDiagnostic : IReadOnlyCompilerControlStatement
{
    LeftParenthesis ValueArgumentStart { get; }
    
    IReadOnlyStringLiteral Value { get; }
    
    RightParenthesis ValueArgumentEnd { get; }
}
