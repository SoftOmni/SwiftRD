using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public interface IReadOnlyAvailabilityArgumentsList : IReadOnlyList<IReadOnlyAvailabilityArgument>
{
    IReadOnlyList<IReadOnlyAvailabilityArgument> Arguments { get; }
    
    IReadOnlyList<Comma> ArgumentSeparators { get; }
}
