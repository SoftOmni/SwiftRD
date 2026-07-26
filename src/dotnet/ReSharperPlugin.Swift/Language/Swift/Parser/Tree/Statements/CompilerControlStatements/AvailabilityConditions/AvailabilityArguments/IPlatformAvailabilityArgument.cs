namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IPlatformAvailabilityArgument : IReadOnlyPlatformAvailabilityArgument, IAvailabilityArgument
{
    new IPlatformName Platform { get; }

    void ChangePlatform(IPlatformName newPlatform);
    
    new IPlatformVersion Version { get; }

    void ChangePlatformVersion(IPlatformVersion newVersion);
}
