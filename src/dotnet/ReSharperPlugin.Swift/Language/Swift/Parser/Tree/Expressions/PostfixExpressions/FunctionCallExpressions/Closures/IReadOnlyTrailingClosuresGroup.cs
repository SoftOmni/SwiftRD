using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public interface IReadOnlyTrailingClosuresGroup : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyLabeledTrailingExpression>
{
    IReadOnlyClosureExpression FirstClosure { get; }
    
    IReadOnlyList<IReadOnlyLabeledTrailingExpression> TrailingLabeledClosureExpressions { get; }
    
    new int Count { get; }

    new IEnumerator<IReadOnlyLabeledTrailingExpression> GetEnumerator();
    
    new IReadOnlyLabeledTrailingExpression this[int index] { get; }
}
