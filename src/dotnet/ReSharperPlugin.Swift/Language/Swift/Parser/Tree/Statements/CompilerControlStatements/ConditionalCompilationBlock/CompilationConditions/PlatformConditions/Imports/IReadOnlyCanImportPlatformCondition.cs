using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.Imports;

public interface IReadOnlyCanImportPlatformCondition : IReadOnlyPlatformCondition
{
    IReadOnlyImportPath ImportPath { get; }
}
