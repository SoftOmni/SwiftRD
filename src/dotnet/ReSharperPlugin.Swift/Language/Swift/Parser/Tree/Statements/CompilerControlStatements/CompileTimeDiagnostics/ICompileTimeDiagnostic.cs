using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public interface ICompileTimeDiagnostic : IReadOnlyCompileTimeDiagnostic, ICompilerControlStatement
{
    new IStringLiteral Value { get; }

    void ChangeValue();
}
