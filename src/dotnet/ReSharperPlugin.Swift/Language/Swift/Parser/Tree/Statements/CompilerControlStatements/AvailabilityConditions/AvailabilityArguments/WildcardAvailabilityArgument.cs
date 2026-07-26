using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public class WildcardAvailabilityArgument : SwiftCompositeNode, IWildcardAvailabilityArgument
{
    public IReadOnlyOperator WildcardOperator { get; }

    internal WildcardAvailabilityArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IReadOnlyOperator wildcardOperator)
        : base(buffer, children)
    {
        WildcardOperator = wildcardOperator;
    }
    
    
}
