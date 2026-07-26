using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.CompilerVersions;

public interface ICompilerVersionPlatformCondition :
    IReadOnlyCompilerVersionPlatformCondition,
    IPlatformCondition
{
    new ISwiftVersion SwiftVersion { get; }

    void MakeLessThan();

    void MakeGreaterThanOrEqual();
}
