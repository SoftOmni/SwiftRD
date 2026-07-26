using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.TargetEnvironment;

public interface IReadOnlyTargetEnvironmentPlatformCondition : IReadOnlyPlatformCondition
{
    IReadOnlyIdentifier TargetEnvironment { get; }

    bool IsSimulator();

    bool IsMacCatalyst();

    bool IsVirtualized();

    bool IsRepl();

    bool IsPureInterpreted();

    bool IsJustInTimeCompiled();
}
