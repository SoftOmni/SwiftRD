using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.Imports;

public interface ICanImportPlatformCondition : 
    IReadOnlyCanImportPlatformCondition, 
    IPlatformCondition
{
    new IImportPath ImportPath { get; }

    void ChangeImportPath(IImportPath newImportPath);
}
