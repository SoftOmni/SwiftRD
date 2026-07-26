namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public interface IReadOnlyUnavailableAvailabilityCondition : IReadOnlyAvailabilityCondition
{
    ReservedUnavailableKeyword UnavailableKeyword { get; }
}
