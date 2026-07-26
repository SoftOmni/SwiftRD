using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.Architectures;

public interface IArchitecturePlatformCondition
    : IReadOnlyArchitecturePlatformCondition,
        IPlatformCondition
{
    new IIdentifier Architecture { get; }

    void ChangeOperatingSystem(IIdentifier newArchitecture);
    
    void ChangeTo32BitX86();

    void ChangeTo64BitX86();

    void ChangeTo32BitArm();

    void ChangeTo64BitArm();

    void ChangeTo32BitWasm();

    void ChangeTo64BitWasm();

    void ChangeTo32BitVersion();

    void ChangeTo64BitVersion();
}
