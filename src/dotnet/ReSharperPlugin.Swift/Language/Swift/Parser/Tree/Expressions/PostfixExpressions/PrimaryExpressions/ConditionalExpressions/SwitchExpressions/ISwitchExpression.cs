using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.SwitchExpressions;

public interface ISwitchExpression : IReadOnlySwitchExpression, IConditionalExpression, IList<ISwitchExpressionCase>
{
    new IExpression Expression { get; }
    
    new IReadOnlyList<ISwitchExpressionCase> Cases { get; }
    
    new int Count { get; }

    new IEnumerator<ISwitchExpressionCase> GetEnumerator();
    
    new ISwitchExpressionCase this[int index] { get; }
}