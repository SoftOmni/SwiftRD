using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;

public interface IInfixExpressionGroup : IReadOnlyInfixExpressionGroup, IList<IInfixExpression>
{
    new int Count { get; }

    new IEnumerator<IInfixExpression> GetEnumerator();

    new IInfixExpression this[int index] { get; }
}
