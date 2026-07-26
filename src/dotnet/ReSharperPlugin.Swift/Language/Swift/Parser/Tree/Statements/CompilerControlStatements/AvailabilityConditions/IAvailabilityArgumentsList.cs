using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public interface IAvailabilityArgumentsList : IReadOnlyAvailabilityArgumentsList,
    IList<IAvailabilityArgument>
{
    new IReadOnlyList<IAvailabilityArgument> Arguments { get; }
    
    new int Count { get; }

    new IEnumerator<IAvailabilityArgument> GetEnumerator();
    
    new IAvailabilityArgument this[int index] { get; set; }
}
