namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public interface IReadOnlyErrorCompileTimeDiagnostic : IReadOnlyCompileTimeDiagnostic
{
    ErrorDirective ErrorDirective { get; }
}