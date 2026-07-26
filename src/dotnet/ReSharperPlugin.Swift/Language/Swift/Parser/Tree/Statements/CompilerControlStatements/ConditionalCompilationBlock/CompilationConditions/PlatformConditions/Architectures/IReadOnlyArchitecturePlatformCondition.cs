using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions.Architectures;

public interface IReadOnlyArchitecturePlatformCondition : IReadOnlyPlatformCondition
{
    IReadOnlyIdentifier Architecture { get; }

    bool Is64BitX86();

    bool Is32BitX86();

    bool IsX86();

    bool IsI386();

    bool IsArm32();

    bool IsArm64();

    bool IsArm();

    bool IsWasm32();

    bool IsWasm64();

    bool IsWasm();

    bool Is32Bit();

    bool Is64Bit();

    int ArchitectureBitWidth();

    int ArchitectureByeWidth();
}
