using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.OperatingSystems;

public interface IReadOnlyOperatingSystemPlatformCondition
    : IReadOnlyPlatformCondition
{
    IReadOnlyIdentifier OperatingSystem { get; }

    bool IsMacOs();

    bool IsIOs();

    bool IsWatchOs();

    bool IsTvOs();

    bool IsVisionOs();

    bool IsLinux();

    bool IsWindows();

    bool IsAndroid();

    bool IsBsd();

    bool IsXnuBased();
}
