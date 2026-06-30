using System.Collections.Generic;
using JetBrains.Application.Components;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public interface ITupleExpression : IReadOnlyTupleExpression, IPrimaryExpression, IList<ITupleExpressionElement>
{
    new IReadOnlyList<ITupleExpressionElement> Elements { get; }
    
    new int Count { get; }

    new IEnumerator<ITupleExpressionElement> GetEnumerator();
    
    new ITupleExpressionElement this[int index] { get; }
}
