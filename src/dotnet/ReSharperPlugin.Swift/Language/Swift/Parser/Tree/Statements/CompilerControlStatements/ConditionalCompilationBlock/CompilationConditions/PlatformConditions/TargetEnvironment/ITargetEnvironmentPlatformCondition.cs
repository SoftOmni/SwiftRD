using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.TargetEnvironment;

public interface ITargetEnvironmentPlatformCondition :
    IReadOnlyTargetEnvironmentPlatformCondition,
    IPlatformCondition
{
    new IIdentifier TargetEnvironment { get; }

    void MakeSimulator();

    void MakeMacCatalyst();

    void MakeVirtualized();

    void MakeRepl();

    void MakePureInterpreted();

    void MakeJustInTimeCompiled();
    
    void ChangeTargetEnvironment(IIdentifier newTargetEnvironment);
}
