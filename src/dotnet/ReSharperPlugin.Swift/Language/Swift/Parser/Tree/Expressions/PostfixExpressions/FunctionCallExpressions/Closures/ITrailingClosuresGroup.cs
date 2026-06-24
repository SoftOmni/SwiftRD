using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public interface ITrailingClosuresGroup : IReadOnlyTrailingClosuresGroup, IList<ILabeledTrailingExpression>
{
    new IClosureExpression FirstClosure { get; }
    
    new int Count { get; }

    new IEnumerator<ILabeledTrailingExpression> GetEnumerator();
    
    new ILabeledTrailingExpression this[int index] { get; }
}
