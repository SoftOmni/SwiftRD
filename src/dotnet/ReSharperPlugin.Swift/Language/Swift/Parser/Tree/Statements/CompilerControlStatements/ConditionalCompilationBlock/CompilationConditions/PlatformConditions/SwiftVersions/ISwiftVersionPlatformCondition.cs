namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.SwiftVersions;

public interface ISwiftVersionPlatformCondition :
    IReadOnlySwiftVersionPlatformCondition,
    IPlatformCondition
{
    new ISwiftVersion SwiftVersion { get; }

    void MakeLessThan();

    void MakeGreaterThanOrEqual();
}
