using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.OperatingSystems;

public interface IOperatingSystemPlatformCondition :
    IReadOnlyOperatingSystemPlatformCondition,
    IPlatformCondition
{
    new IIdentifier OperatingSystem { get; }

    void ChangeOperatingSystem(IIdentifier newOperatingSystemIdentifier);
    
    void ChangeToMacOs();

    void ChangeToIOs();

    void ChangeToWatchOs();

    void ChangeToTvOs();

    void ChangeToVisionOs();

    void ChangeToLinux();

    void ChangeToWindows();

    void ChangeToAndroid();
}
