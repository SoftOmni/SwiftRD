namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public interface IReadOnlyWarningCompileTimeDiagnostic : IReadOnlyCompileTimeDiagnostic
{
    WarningDirective WarningDirective { get; }
}
