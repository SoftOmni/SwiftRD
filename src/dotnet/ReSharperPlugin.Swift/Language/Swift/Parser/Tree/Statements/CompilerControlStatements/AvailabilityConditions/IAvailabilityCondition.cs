using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public interface IAvailabilityCondition : IReadOnlyAvailabilityCondition,
    IList<IAvailabilityArgument>, ICondition
{
    new IAvailabilityArgumentsList ArgumentsList { get; }
    
    new IReadOnlyList<IAvailabilityArgument> Arguments { get; }
    
    new int Count { get; }

    new IEnumerator<IAvailabilityArgument> GetEnumerator();
    
    new IAvailabilityArgument this[int index] { get; set; }

    void ChangeArgumentsList(IAvailabilityArgumentsList newArgumentsList);
}
