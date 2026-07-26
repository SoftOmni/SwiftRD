using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public interface IReadOnlyAvailabilityCondition : ISwiftNode<SwiftCompositeNode>, 
    IReadOnlyList<IReadOnlyAvailabilityArgument>, IReadOnlyCondition
{
    LeftParenthesis ArgumentsStart { get; }
    
    IReadOnlyAvailabilityArgumentsList ArgumentsList { get; }
    
    IReadOnlyList<IReadOnlyAvailabilityArgument> Arguments { get; }
    
    RightParenthesis ArgumentsEnd { get; }
}
