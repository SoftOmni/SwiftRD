using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.CompilerVersions;

public interface IReadOnlyCompilerVersionPlatformCondition : IReadOnlyPlatformCondition
{
    IReadOnlyOperator Operator { get; }
    
    IReadOnlySwiftVersion SwiftVersion { get; }

    void IsLessThan();

    void IsGreaterThanOrEqual();
}
