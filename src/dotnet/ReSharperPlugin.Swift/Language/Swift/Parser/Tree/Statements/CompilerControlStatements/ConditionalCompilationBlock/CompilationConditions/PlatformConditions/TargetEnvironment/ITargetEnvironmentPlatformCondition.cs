using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.TargetEnvironnment;

public interface ITargetEnvironmentPlatformCondition :
    IReadOnlyTargetEnvironmentPlatformCondition,
    IPlatformCondition
{
    new IIdentifier TargetEnvironment { get; }

    void MakeSimulator();

    void MakeMacCatalyst();

    void MakeVirtualized();

    void MakeRepl();
    
    void Make
    
    void ChangeTargetEnvironment(IIdentifier newTargetEnvironment);
}
