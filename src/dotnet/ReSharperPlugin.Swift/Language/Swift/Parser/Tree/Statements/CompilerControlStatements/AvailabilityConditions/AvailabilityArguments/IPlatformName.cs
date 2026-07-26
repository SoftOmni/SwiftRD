using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IPlatformName : IReadOnlyPlatformName
{
    new IIdentifier Platform { get; }

    void ChangePlatform(IIdentifier newPlatform);

    void MakeExtension();

    void MakeStandalone();

    void MakeIOs();

    void MakeMacOs();

    void MakeWatchOs();

    void MakeTvOs();

    void MakeVisionOs();
}
