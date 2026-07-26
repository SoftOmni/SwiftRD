using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IReadOnlyWildcardAvailabilityArgument : IReadOnlyAvailabilityArgument
{
    IReadOnlyOperator WildcardOperator { get; }
}
