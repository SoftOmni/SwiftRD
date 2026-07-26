namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IReadOnlyPlatformAvailabilityArgument : IReadOnlyAvailabilityArgument
{
    IReadOnlyPlatformName Platform { get; }
    
    IReadOnlyPlatformVersion Version { get; }
}
