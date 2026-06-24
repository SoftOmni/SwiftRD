using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public interface IElseIfExpression : IReadOnlyElseIfExpression, IList<IStatement>
{
    new IReadOnlyList<IStatement> Statements { get; }
    
    new int Count { get; }

    new IEnumerator<IStatement> GetEnumerator();
    
    new IStatement this[int index] { get; }
}
