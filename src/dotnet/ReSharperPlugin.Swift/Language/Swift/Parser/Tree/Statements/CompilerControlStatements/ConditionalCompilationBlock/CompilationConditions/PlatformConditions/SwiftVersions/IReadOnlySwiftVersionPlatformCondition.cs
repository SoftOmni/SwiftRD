using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.CompilerVersions;

public interface IReadOnlyCompilerVersionPlatformCondition : IReadOnlyPlatformCondition
{
    IReadOnlyOperator Operator { get; }
    
    IReadOnlySwiftVersion SwiftVersion { get; }

    void IsLessThan();

    void IsGreaterThanOrEqual();
}
